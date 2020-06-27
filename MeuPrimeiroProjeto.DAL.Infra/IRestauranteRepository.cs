using MeuPrimeiroProjeto.Entities;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL.Infra
{
    public interface IRestauranteRepository : IRepository
    {
        Task<Restaurante> GetRestauranteAsync(string restName, string restEndereco, int restVotos);

        void CreateRestauranteAsync(Restaurante restaurante);

        void UpdateRestauranteAsync(Restaurante restaurante);
    }
}
