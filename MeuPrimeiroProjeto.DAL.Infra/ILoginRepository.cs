using MeuPrimeiroProjeto.Entities;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL.Infra
{
    public interface ILoginRepository: IRepository
    {
        Task<Login> GetLoginAsync(string nickName, string pwd);

        void CreateLoginAsync(Login login);

        void UpdateLoginAsync(Login login);
    }
}
