using MeuPrimeiroProjeto.DAL.DataBaseContext;
using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL
{
    public class RestauranteRepository : IRestauranteRepository
    {
        private readonly MeuPrimeiroProjetoDbContext _dbContext;

        private List<Restaurante> restaurantes = new List<Restaurante>();

        public RestauranteRepository(MeuPrimeiroProjetoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUnityOfWork UnityOfWork => _dbContext;

        //Get All

        public IEnumerable<Restaurante> GetAll()
        {
            return restaurantes;
        }


        //Get

        async Task<List<Restaurante>> IRestauranteRepository.GetRestauranteAsync(string restName, string restEndereco, int restVotos, string restImagem)
        {
            return await _dbContext.Restaurantes.ToListAsync();
        }

        //Post

        void IRestauranteRepository.CreateRestauranteAsync(Restaurante restaurante)
        {
            _dbContext.Restaurantes.Add(restaurante);
        }

        //Put

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
