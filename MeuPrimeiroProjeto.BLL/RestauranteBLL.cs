using MeuPrimeiroProjeto.BLL.Infra;
using MeuPrimeiroProjeto.DAL;
using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using System;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.BLL
{
    public class RestauranteBLL : IRestauranteBLL
    {

        private readonly IRestauranteRepository _restauranteRepository;

        public RestauranteBLL(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        public async Task<Restaurante> GetRestauranteAsync(string restName, string restEndereco, int restVotos)
        {
            //VERIFICA SE OS DADOS QUE SERÃO CONSTRUÍDOS ESTÃO OK
            new Restaurante(id: 0, restName: restName, restEndereco: restEndereco, restVotos: restVotos);

            return await _restauranteRepository.GetRestauranteAsync(restName, restEndereco, restVotos);
        }

        ///<summary>
        ///METODO RESPONSAVEL POR PERSISTIR
        ///</summary>
        ///<param restName="restaurante">OBJETO RESTAURANTE</param>

        public async Task CreateRestauranteAsync(Restaurante restaurante)
        {
            _restauranteRepository.CreateRestauranteAsync(restaurante);
            await _restauranteRepository.UnityOfWork.Commit();
        }

        ///<summary>
        ///METODO RESPONSAVEL POR ATUALIZAR O OBJETO
        /// </summary>
        /// <param nameRest="restaurante">OBJETO RESTAURANTE</param>

        public async Task UpdateRestauranteAsync(Restaurante restaurante)
        {
            _restauranteRepository.UpdateRestauranteAsync(restaurante);
            await _restauranteRepository.UnityOfWork.Commit();
        }

        public void Dispose()
        {
            _restauranteRepository?.Dispose();
        }

    }
    
}
