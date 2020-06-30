using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MeuPrimeiroProjeto.BLL.Infra;
using MeuPrimeiroProjeto.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace MeuPrimeiroProjeto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private IRestauranteBLL _restauranteBLL;

        List<IRestauranteBLL> _restaurantes = new List<IRestauranteBLL>();

        public RestauranteController(IRestauranteBLL restauranteBLL)
        {
            _restauranteBLL = restauranteBLL;
        }

        [Route("get"), HttpGet]

        public async Task<IActionResult> Get(string restName, string restEndereco, int restVotos, string restImagem)
        {
            var responseContent = new ResponseContent();

            try
            {
                responseContent.Object = await _restauranteBLL.GetRestauranteAsync(restName, restEndereco, restVotos, restImagem);

                if(responseContent.Object==null){
                    responseContent.Message = "A pesquisa não retornou dados.";
                    return NotFound(responseContent);
                }
                responseContent.Message = "Operação realizada com sucesso.";
                return Ok(responseContent);
            }
            catch (BusinessException bex)
            {
                responseContent.Message = bex.Message;
                return BadRequest(responseContent);
            }
            catch (Exception ex)
            {
                responseContent.Message = ex.Message;
                return BadRequest(responseContent);
            }
        }
    }
    
}
