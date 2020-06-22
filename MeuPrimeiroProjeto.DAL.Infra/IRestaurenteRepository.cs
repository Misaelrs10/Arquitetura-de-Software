using MeuPrimeiroProjeto.Entities;

namespace MeuPrimeiroProjeto.DAL.Infra
{
    interface IRestaurenteRepository : IRepository
    {
        void CreateRestauranteAsync(Restaurante restaurante);

        void UpdateRestauranteAsync(Restaurante restaurante);

        void DeleteRestauranteAsync(Restaurante restaurante);

    }
}
