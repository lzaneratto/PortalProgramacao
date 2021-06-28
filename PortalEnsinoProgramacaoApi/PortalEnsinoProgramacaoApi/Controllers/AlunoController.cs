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
    public class AlunoController : ControllerBase
    {
     
        [HttpGet("ListarAluno/{matricula}")]
        public IActionResult Index(string Matricula)
        {
            return Ok();
        
        }

        [HttpPost]
        [Route("EntregarTrabalho")]
        public IActionResult Cadastrar()
        {
            return Ok();
        }

    }
}
