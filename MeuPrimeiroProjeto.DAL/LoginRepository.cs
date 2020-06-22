using MeuPrimeiroProjeto.DAL.DataBaseContext;
using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL
{
    public class LoginRepository : ILoginRepository
    {
        private readonly MeuPrimeiroProjetoDbContext _dbContext;

        public LoginRepository (MeuPrimeiroProjetoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUnityOfWork UnityOfWork => _dbContext;

        ///<summary>
        ///METODO RESPONSAVEL POR RETORNAR O LOGIN DO USUARIO
        ///</summary>
        ///<param name="nickName">LOGIN DO USUARIO</param>
        ///<param name="pwd">SENHA DO USUARIO</param>
        ///<returns> OBJETO LOGIN</returns>

        public async Task<Login> GetLoginAsync(string nickName, string pwd)
        {
            return await _dbContext.Login.Where(x => x.NickName.Equals(nickName) && x.Pwd.Equals(pwd)).FirstOrDefaultAsync();
        }

        ///<summary>
        ///METODO RESPONSAVEL POR PERSISTIR O LOGIN
        ///</summary>
        ///<param name="login">OBJETO DE LOGIN</param>

        public void CreateLoginAsync(Login login)
        {
            _dbContext.Login.Add(login);
        }

        ///<summary>
        ///METODO RESPONSAVEL POR ATUALIZAR O OBJETO LOGIN
        /// </summary>
        /// <param name="login">OBJETO LOGIN</param>

        public void UpdateLoginAsync(Login login)
        {
            //VERIFICA SE O OBJETO FOI ATACHADO
            bool isDetached = _dbContext.Entry(login).State == EntityState.Detached;
            if (isDetached)
                _dbContext.Login.Attach(login);

            _dbContext.Login.Update(login);
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }


}
