using System.Collections.Generic;
using AppUsuariosData;
using PrimeraPreEntrega;

namespace AppUsuariosBusiness
{
    public class UsuariosBusiness
    {
        public static List<Usuarios> GetUsuarios()
        {
            return UsuariosData.GetUsuarios();
        }

        public static void CreateUsuario(Usuarios usuario)
        {
            UsuariosData.CreateUsuario(usuario);
        }

        public static void UpdateUsuario(Usuarios usuario)
        {
            UsuariosData.UpdateUsuario(usuario);
        }

        public static void DeleteUsuario(int id)
        {
            UsuariosData.DeleteUsuario(id);
        }
    }
}
