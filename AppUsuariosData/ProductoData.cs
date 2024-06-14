using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using AppUsuariosEntities;

namespace AppUsuariosData
{
    public static class ProductoData
    {
        public static void CreateProducto(Producto producto)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var insertQuery = "INSERT INTO Producto (Descripcion, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, conexion))
                {
                    command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    command.Parameters.AddWithValue("@Costo", producto.Costo);
                    command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    command.Parameters.AddWithValue("@Stock", producto.Stock);
                    command.Parameters.AddWithValue("@IdUsuario", producto.IdUsuario);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteProducto(int id)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var deleteQuery = "DELETE FROM Producto WHERE Id = @Id";

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

        public static List<Producto> GetProduct()
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            List<Producto> listaProducto = new List<Producto>();

            string query = "SELECT * FROM Producto";
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
                                    Producto producto = new Producto
                                    {
                                        Id = Convert.ToInt32(dr["Id"]),
                                        Descripcion = dr["Descripcion"].ToString(),
                                        Costo = Convert.ToDouble(dr["Costo"]),
                                        PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]),
                                        Stock = Convert.ToInt32(dr["Stock"]),
                                        IdUsuario = Convert.ToInt32(dr["IdUsuario"])
                                    };

                                    listaProducto.Add(producto);
                                }
                            }
                            return listaProducto;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
                return listaProducto;
            }
        }

        public static void UpdateProducto(Producto producto)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var updateQuery = "UPDATE Producto SET Descripcion=@Descripcion, Costo=@Costo, PrecioVenta=@PrecioVenta, Stock=@Stock, IdUsuario=@IdUsuario WHERE Id=@Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(updateQuery, conexion))
                {
                    command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    command.Parameters.AddWithValue("@Costo", producto.Costo);
                    command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                    command.Parameters.AddWithValue("@Stock", producto.Stock);
                    command.Parameters.AddWithValue("@IdUsuario", producto.IdUsuario);
                    command.Parameters.AddWithValue("@Id", producto.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
