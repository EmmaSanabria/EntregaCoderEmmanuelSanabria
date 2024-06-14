using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AppUsuariosBusiness;
using AppUsuariosEntities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVentas")]
        public ActionResult<IEnumerable<Venta>> GetVentas()
        {
            var ventas = VentaBusiness.GetVentas();
            return Ok(ventas);
        }

        [HttpPost]
        public ActionResult CreateVenta([FromBody] Venta venta)
        {
            VentaBusiness.CreateVenta(venta);
            return CreatedAtAction(nameof(GetVentas), new { id = venta.id }, venta);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateVenta(int id, [FromBody] Venta venta)
        {
            if (id != venta.id)
            {
                return BadRequest();
            }

            VentaBusiness.UpdateVenta(venta);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteVenta(int id)
        {
            VentaBusiness.DeleteVenta(id);
            return NoContent();
        }
    }
}
