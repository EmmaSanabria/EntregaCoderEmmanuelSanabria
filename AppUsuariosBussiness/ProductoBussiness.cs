using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppUsuariosData;
using AppUsuariosEntities;

namespace AppUsuariosBussiness
{
    public class ProductoBussiness
    {
        public static List<Producto> GetProduct()
        {
            return ProductoData.GetProduct();
        }
    }
}
