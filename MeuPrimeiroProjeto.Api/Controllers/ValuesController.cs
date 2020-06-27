using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeuPrimeiroProjeto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route ("name/{name}"),HttpGet]
        
        public IActionResult GetName(String name)
        {
            try
            {
                return Ok(name + ", você está matriculado no curso de pós graduação em engenharia de software.");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
