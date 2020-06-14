using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL.Infra
{
    public interface IUnityOfWork
    {
        Task<bool> Commit();
    }
}
