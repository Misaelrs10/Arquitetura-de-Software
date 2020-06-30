using MeuPrimeiroProjeto.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.BLL.Infra
{
    public interface IRestauranteBLL : IDisposable
    {
        Task<List<Restaurante>> GetRestauranteAsync(string restName, string restEndereco, int restVotos, string restImagem);

        Task CreateRestauranteAsync(Restaurante restaurante);

        Task UpdateRestauranteAsync(Restaurante restaurante);
    }

}
