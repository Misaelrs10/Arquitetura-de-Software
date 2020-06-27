using MeuPrimeiroProjeto.BLL.Infra;
using MeuPrimeiroProjeto.DAL;
using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.BLL
{
    public class LoginBLL : ILoginBLL
    {

        private readonly ILoginRepository _loginRepository;

        public LoginBLL(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        ///<summary>
        ///METODO RESPONSAVEL POR RETORNAR O LOGIN DO USUARIO
        ///</summary>
        ///<param name="nickName">LOGIN DO USUARIO</param>
        ///<param name="pwd">SENHA DO USUARIO</param>
        ///<returns> OBJETO LOGIN</returns>

        public async Task<Login> GetLoginAsync(string nickName, string pwd)
        {
            //VERIFICA SE OS DADOSQUE SERÃO CONSTRUÍDOS ESTÃO OK
            new Login(id: 0, nickName: nickName, pwd: pwd);

            return await _loginRepository.GetLoginAsync(nickName, pwd);
        }

        ///<summary>
        ///METODO RESPONSAVEL POR PERSISTIR O LOGIN
        ///</summary>
        ///<param name="login">OBJETO DE LOGIN</param>

        public async Task CreateLoginAsync(Login login)
        {
            _loginRepository.CreateLoginAsync(login);
            await _loginRepository.UnityOfWork.Commit();
        }

        ///<summary>
        ///METODO RESPONSAVEL POR ATUALIZAR O OBJETO LOGIN
        /// </summary>
        /// <param name="login">OBJETO LOGIN</param>

        public async Task UpdateLoginAsync(Login login)
        {
            _loginRepository.UpdateLoginAsync(login);
            await _loginRepository.UnityOfWork.Commit();
        }

        public void Dispose()
        {
            _loginRepository?.Dispose();
        }

    }

    
}
