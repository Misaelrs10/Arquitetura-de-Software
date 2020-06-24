using MeuPrimeiroProjeto.Entities;
using System;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.BLL.Infra
{
    public interface IRestauranteBLL : IDisposable
    {
        Task<Restaurante> GetRestauranteAsync(string restName, string restEndereco, int restVotos);

        Task CreateRestauranteAsync(Restaurante restaurante);

        Task UpdateRestauranteAsync(Restaurante restaurante);
    }

}
