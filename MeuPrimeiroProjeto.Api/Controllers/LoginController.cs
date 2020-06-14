using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuPrimeiroProjeto.BLL.Infra;
using MeuPrimeiroProjeto.Entities;
using MeuPrimeiroProjeto.Entities.DTO;
using MeuPrimeiroProjeto.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeuPrimeiroProjeto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginBLL _loginBLL;

        public LoginController(ILoginBLL loginBLL)
        {
            _loginBLL = loginBLL;
        }

        /// <summary>
        /// PERSISTIR DADOS DE ACESSO
        /// </summary>
        /// <param name="login">OBJETO LOGIN</param>
        /// <returns>OBJETO RESPONSE</returns>
        [Route("post"), HttpPost]

        public async Task<IActionResult> Post([FromBody] LoginDTO login)
        {
            var responseContent = new ResponseContent();

            try
            {
                await _loginBLL.CreateLoginAsync(new Login(id: 0, nickName: login.NickName, pwd: login.Pwd));
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


        /// <summary>
        /// ATUALIZAR DADOS DE ACESSO
        /// </summary>
        /// <param name="login">OBJETO LOGIN</param>
        /// <returns>OBJETO RESPONSE</returns>
        [Route("put"), HttpPut]

        public async Task<IActionResult> Put([FromBody] LoginDTO login)
        {
            var responseContent = new ResponseContent();

            try
            {
                await _loginBLL.CreateLoginAsync(new Login(id: 0, nickName: login.NickName, pwd: login.Pwd));
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

        /// <summary>
        /// CONSULTAR DADOS DE ACESSO
        /// </summary>
        /// <param name="nickName">OBJETO LOGIN</param>
        /// <param name="pwd">SENHA DE ACESSO</param>
        /// <returns></returns>
        [Route("get"), HttpGet]

        public async Task<IActionResult> Get(string nickName, string pwd)
        {
            var responseContent = new ResponseContent();

            try
            {
                responseContent.Object = await _loginBLL.GetLoginAsync(nickName, pwd);

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
