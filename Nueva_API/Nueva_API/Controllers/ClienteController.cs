using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Channels;
using Microsoft.AspNetCore.Http;

namespace Nueva_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        
        [HttpGet]

        public IActionResult Get()

        {
            RPClientes rpCli = new RPClientes();
            return Ok(rpCli.ObtenerClientes());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RPClientes rpCli = new RPClientes();
            var cliRet = rpCli.ObtenerCliente(id);
            if (cliRet == null)
            {
                var nf = NotFound("El cliente " + id.ToString() + " " + "No existe. ");
                return nf;
            }
            return Ok(cliRet);
        }
        [HttpPost("Agregar")]
        public IActionResult AgregarCliente (Cliente nuevoCliente)
        {
            RPClientes rpCli = new RPClientes();
            rpCli.Agregar(nuevoCliente);
            return CreatedAtAction(nameof(AgregarCliente), nuevoCliente);
        }
    }
}
