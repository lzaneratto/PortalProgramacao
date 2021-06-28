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
    public class ProfessorController : ControllerBase
    {
        [HttpPost]
        [Route("CadastrarMaterial")]
        public IActionResult CadastrarMaterial()
        {
            return Ok();
        }

        [HttpGet("ListarProfessor")]
        public IActionResult ListarProfessor(Guid Id)
        {
            return Ok();
        }
    }
}
