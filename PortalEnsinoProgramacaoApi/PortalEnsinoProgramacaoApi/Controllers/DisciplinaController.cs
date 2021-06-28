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
    public class DisciplinaController : ControllerBase
    {
        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar()
        {
            return Ok();
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar()
        {
            return Ok();
        }

        [HttpDelete("Excluir/{id}")]
        public IActionResult Excluir(Guid id)
        {
            return Ok();
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            return Ok();
        }
    }
}
