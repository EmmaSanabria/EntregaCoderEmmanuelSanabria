using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppUsuariosEntities;
using AppUsuariosBussiness;

namespace AppVentaUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> venta()
        {
            return VentaBussiness.GetVenta().ToArray();
        }
    }
}
