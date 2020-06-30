using MeuPrimeiroProjeto.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL.Infra
{
    public interface IRestauranteRepository : IRepository
    {
        IEnumerable<Restaurante> GetAll();

        Task<List<Restaurante>> GetRestauranteAsync(string restName, string restEndereco, int restVotos, string restImagem);

        void CreateRestauranteAsync(Restaurante restaurante);

        void UpdateRestauranteAsync(Restaurante restaurante);
    }
}
