using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AppUsuariosBussiness;
using AppUsuariosEntities;
using AppUsuariosBusiness;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosVendidosController : ControllerBase
    {
        [HttpGet(Name = "GetProductosVendidos")]
        public ActionResult<IEnumerable<ProductosVendidos>> GetProductosVendidos()
        {
            var productosVendidos = ProductosVendidosBussiness.GetProductosVendidos();
            return Ok(productosVendidos);
        }

        [HttpPost(Name = "CreateProductosVendidos")]
        public ActionResult CreateProductoVendido([FromBody] ProductosVendidos productosVendidos)
        {
            ProductosVendidosBussiness.CreateProductoVendido(productosVendidos);
            return CreatedAtAction(nameof(GetProductosVendidos), new { id = productosVendidos.Id }, productosVendidos);
        }

        [HttpPut ("{id}")]
        public ActionResult UpdateProductoVendido(int id, [FromBody] ProductosVendidos productosVendidos)
        {
            if (id != productosVendidos.Id)
            {
                return BadRequest();
            }

            ProductosVendidosBussiness.UpdateProductoVendido(productosVendidos);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteProductoVendido(int id)
        {
            ProductosVendidosBussiness.DeleteProductoVendido(id);
            return NoContent();
        }
    }
}
