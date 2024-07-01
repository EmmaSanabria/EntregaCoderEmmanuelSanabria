using AppUsuariosBusiness;
using AppUsuariosBussiness;
using AppUsuariosEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeraPreEntrega;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Producto> productos()
        {
            return ProductoBussiness.GetProduct().ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.AltaProducto(producto);
        }


        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Producto producto) 
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }
            
            ProductoBussiness.ModificarProducto(producto);
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ProductoBussiness.EliminarProducto(id);
            return NoContent();
        }
    }
}
