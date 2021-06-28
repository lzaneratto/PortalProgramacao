using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEnsinoProgramacaoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : Controller
    {
        [HttpGet("ListarMaterial/{id}")]
        public IActionResult ListarMaterial(Guid Id)
        {
            return Ok();
        }
    }
}
