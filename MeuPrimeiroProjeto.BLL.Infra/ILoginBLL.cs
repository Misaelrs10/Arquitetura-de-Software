using MeuPrimeiroProjeto.Entities;
using System;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.BLL.Infra
{
    public interface ILoginBLL : IDisposable
    {
        Task<Login> GetLoginAsync(string nickName, string pwd);

        Task CreateLoginAsync(Login login);

        Task UpdateLoginAsync(Login login);
    }
}
