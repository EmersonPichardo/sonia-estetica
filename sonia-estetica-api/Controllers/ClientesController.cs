using Microsoft.AspNetCore.Mvc;
using sonia_estetica_dataAccess.Connections;
using sonia_estetica_dataAccess.Models.Benesser;
using System.Linq;

namespace sonia_estetica_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private BenesserContext Context;

        public ClientesController(BenesserContext context)
        {
            Context = context;
        }

        [HttpGet]
        public Cliente[] Get() => Context.Clientes.ToArray();
    }
}
