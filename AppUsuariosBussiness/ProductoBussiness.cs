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
        public static void AltaProducto(Producto producto)
        {
            ProductoData.CreateProducto(producto);
        }

        public static void EliminarProducto(int id)
        {
            ProductoData.DeleteProducto(id);
        }

        public static List<Producto> GetProduct()
        {
            return ProductoData.GetProduct();
        }

        public static void ModificarProducto(Producto producto)
        {
            ProductoData.UpdateProducto(producto);
        }
    }
}
