using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEnsinoProgramacaoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar()
        {
            return Ok();
        }

        
        [HttpDelete("Excluir/{id}")]
        public IActionResult Excluir(Guid id)
        {
            return Ok();
        }
        
        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar()
        {
            return Ok();
        }

        [HttpGet("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok();
        }

        [HttpPost]
        [Route("EfetuarLogin")]
        public IActionResult EfetuarLogin()
        {
            return Ok();
        }

        [HttpPost]
        [Route("DefinirPerfilAdministrador")]
        public IActionResult DefinirPerfilAdministrador()
        {
            return Ok(); 
        }

        [HttpPost]
        [Route("AvaliarTrabalho")]
        public IActionResult AvaliarTrabalho()
        {
            return Ok();
        }


    }
}
