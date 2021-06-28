using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEnsinoProgramacaoApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TrabalhoController : ControllerBase
    {
        [HttpGet("ConsultarTrabalho/{id}")]
        public IActionResult Cadastrar(Guid Id)
        {
            return Ok();
        }

        [HttpGet("VerificarAvaliacoes/{id}")]
        public IActionResult VerificarAvaliacoes(Guid Id)
        {
            return Ok();
        }
    }
}
