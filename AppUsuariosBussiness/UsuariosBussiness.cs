using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppUsuariosData;
using AppUsuariosEntities;
using PrimeraPreEntrega;

namespace AppUsuariosBussiness
{
    public class UsuariosBussiness
    {
        public static List<Usuarios> GetUsuario()
        {
            return UsuariosData.GetUsuario();
        }
    }
}
