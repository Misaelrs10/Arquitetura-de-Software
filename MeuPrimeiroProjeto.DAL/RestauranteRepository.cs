using MeuPrimeiroProjeto.DAL.DataBaseContext;
using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL
{
    public class RestauranteRepository : IRestauranteRepository
    {
        private readonly MeuPrimeiroProjetoDbContext _dbContext;

        public RestauranteRepository(MeuPrimeiroProjetoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUnityOfWork UnityOfWork => _dbContext;

        async Task<Restaurante> IRestauranteRepository.GetRestauranteAsync(string restName, string restEndereco, int restVotos)
        {
            return await _dbContext.Restaurantes.FirstOrDefaultAsync();
        }

        void IRestauranteRepository.CreateRestauranteAsync(Restaurante restaurante)
        {
            _dbContext.Restaurantes.Add(restaurante);
        }

        void IRestauranteRepository.UpdateRestauranteAsync(Restaurante restaurante)
        {
            //VERIFICA SE O OBJETO FOI ATACHADO
            bool isDetached = _dbContext.Entry(restaurante).State == EntityState.Detached;
            if (isDetached)
                _dbContext.Restaurantes.Attach(restaurante);

            _dbContext.Restaurantes.Update(restaurante);
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

    }

}
