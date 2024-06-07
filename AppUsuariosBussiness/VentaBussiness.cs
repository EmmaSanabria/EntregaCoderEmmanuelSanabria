using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppUsuariosData;
using AppUsuariosEntities;

namespace AppUsuariosBussiness
{
    public class VentaBussiness
    {
        public static List<Venta> GetVenta()
        {
            return VentaData.GetVenta();
        }
    }
}
