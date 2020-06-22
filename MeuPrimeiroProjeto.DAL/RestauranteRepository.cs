using MeuPrimeiroProjeto.DAL.DataBaseContext;
using MeuPrimeiroProjeto.DAL.Infra;

namespace MeuPrimeiroProjeto.DAL
{
    public class RestauranteRepository : IRestauranteRepository
    {
        private readonly MeuPrimeiroProjetoDbContext _dbContext;

        public RestauranteRepository (MeuPrimeiroProjetoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUnityOfWork UnityOfWork => _dbContext;

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }

    public interface IRestauranteRepository
    {
    }
}
