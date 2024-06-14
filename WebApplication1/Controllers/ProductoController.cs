using AppUsuariosBussiness;
using AppUsuariosEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> productos()
        {
            return ProductoBussiness.GetProduct().ToArray();
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int id) 
        {
            ProductoBussiness.EliminarProducto(id);
        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto) 
        {
            ProductoBussiness.ModificarProducto(producto);
        }

        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] Producto producto) 
        {
            ProductoBussiness.AltaProducto(producto);
        }
    }
}
