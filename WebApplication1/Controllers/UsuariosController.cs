using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AppUsuariosBusiness;
using PrimeraPreEntrega;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Usuarios>> GetUsuarios()
        {
            var usuarios = UsuariosBusiness.GetUsuarios();
            return Ok(usuarios);
        }

        [HttpPost]
        public ActionResult CreateUsuario([FromBody] Usuarios usuario)
        {
            UsuariosBusiness.CreateUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuarios), new { id = usuario.id }, usuario);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateUsuario(int id, [FromBody] Usuarios usuario)
        {
            if (id != usuario.id)
            {
                return BadRequest();
            }

            UsuariosBusiness.UpdateUsuario(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUsuario(int id)
        {
            UsuariosBusiness.DeleteUsuario(id);
            return NoContent();
        }
    }
}
