using System.Collections.Generic;
using AppUsuariosData;
using AppUsuariosEntities;

namespace AppUsuariosBusiness
{
    public class ProductosVendidosBussiness
    {
        public static List<ProductosVendidos> GetProductosVendidos()
        {
            return ProductosVendidosData.GetProductSold();
        }

        public static void CreateProductoVendido(ProductosVendidos productosVendidos)
        {
            ProductosVendidosData.CreateProductoVendido(productosVendidos);
        }

        public static void UpdateProductoVendido(ProductosVendidos productosVendidos)
        {
            ProductosVendidosData.UpdateProductoVendido(productosVendidos);
        }

        public static void DeleteProductoVendido(int id)
        {
            ProductosVendidosData.DeleteProductoVendido(id);
        }
    }
}
