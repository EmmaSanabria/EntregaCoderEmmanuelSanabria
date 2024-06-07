using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppUsuariosEntities;

namespace AppUsuariosData
{
    public static class ProductosVendidosData
    {
        public static List<ProductosVendidos> GetProductSold()
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            List<ProductosVendidos> listaProductosVendidos = new List<ProductosVendidos>();

            string query = "SELECT * FROM ProductosVendidos";
            try
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    connexion.Open();
                    using (SqlCommand command = new SqlCommand(query, connexion))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    ProductosVendidos productosVendidos = new ProductosVendidos();

                                    productosVendidos.id = Convert.ToInt32(dr["Id"]);
                                    productosVendidos.idProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productosVendidos.stock = Convert.ToInt32(dr["Stock"]);
                                    productosVendidos.idVenta = Convert.ToInt32(dr["IdVenta"]);                                      

                                    listaProductosVendidos.Add(productosVendidos);
                                }
                            }
                            return listaProductosVendidos;
                        }
                    }
                    connexion.Close();
                }
            }
            catch (Exception ex)
            {
                return listaProductosVendidos;
            }
        }
    }
}
