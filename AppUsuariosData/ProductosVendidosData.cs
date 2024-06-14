using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using AppUsuariosEntities;

namespace AppUsuariosData
{
    public static class ProductosVendidosData
    {
        private static string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";

        public static List<ProductosVendidos> GetProductSold()
        {
            List<ProductosVendidos> listaProductosVendidos = new List<ProductosVendidos>();
            string query = "SELECT * FROM ProductosVendidos";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ProductosVendidos productosVendidos = new ProductosVendidos
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                    Stock = Convert.ToInt32(dr["Stock"]),
                                    IdVenta = Convert.ToInt32(dr["IdVenta"])
                                };

                                listaProductosVendidos.Add(productosVendidos);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }

            return listaProductosVendidos;
        }

        public static void CreateProductoVendido(ProductosVendidos productosVendidos)
        {
            string insertQuery = "INSERT INTO ProductosVendidos (IdProducto, Stock, IdVenta) VALUES (@IdProducto, @Stock, @IdVenta)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@IdProducto", productosVendidos.IdProducto);
                        command.Parameters.AddWithValue("@Stock", productosVendidos.Stock);
                        command.Parameters.AddWithValue("@IdVenta", productosVendidos.IdVenta);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }
        }

        public static void UpdateProductoVendido(ProductosVendidos productosVendidos)
        {
            string updateQuery = "UPDATE ProductosVendidos SET IdProducto=@IdProducto, Stock=@Stock, IdVenta=@IdVenta WHERE Id=@Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", productosVendidos.Id);
                        command.Parameters.AddWithValue("@IdProducto", productosVendidos.IdProducto);
                        command.Parameters.AddWithValue("@Stock", productosVendidos.Stock);
                        command.Parameters.AddWithValue("@IdVenta", productosVendidos.IdVenta);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }
        }

        public static void DeleteProductoVendido(int id)
        {
            string deleteQuery = "DELETE FROM ProductosVendidos WHERE Id=@Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }
        }
    }
}
