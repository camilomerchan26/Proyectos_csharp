using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nueva_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()

        {
            RPUsuarios rpCli = new RPUsuarios();
            return Ok(rpCli.ObtenerClientes());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RPUsuarios rpCli = new RPUsuarios();
            var cliRet = rpCli.ObtenerCliente(id);
            if (cliRet == null)
            {
                var nf = NotFound("el Sr " + id.ToString() + " " + "No existe. ");
                return nf;
            }
            return Ok(cliRet);
        }
        [HttpPost("Agregar")]
        public IActionResult AgregarCliente(Cliente nuevoCliente)
        {
            RPClientes rpCli = new RPClientes();
            rpCli.Agregar(nuevoCliente);
            return CreatedAtAction(nameof(AgregarCliente), nuevoCliente);
        }

    }
}
