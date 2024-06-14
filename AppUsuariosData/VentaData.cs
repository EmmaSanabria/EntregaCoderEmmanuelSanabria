using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using AppUsuariosEntities;

namespace AppUsuariosData
{
    public static class VentaData
    {
        private static string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";

        public static List<Venta> GetVentas()
        {
            List<Venta> listaVentas = new List<Venta>();
            string query = "SELECT * FROM Venta";

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
                                Venta venta = new Venta
                                {
                                    id = Convert.ToInt32(dr["Id"]),
                                    comentarios = dr["Comentarios"].ToString(),
                                    idUsuario = Convert.ToInt32(dr["IdUsuario"])
                                };

                                listaVentas.Add(venta);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }

            return listaVentas;
        }

        public static void CreateVenta(Venta venta)
        {
            string insertQuery = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@Comentarios, @IdUsuario)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@Comentarios", venta.comentarios);
                        command.Parameters.AddWithValue("@IdUsuario", venta.idUsuario);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }
        }

        public static void UpdateVenta(Venta venta)
        {
            string updateQuery = "UPDATE Venta SET Comentarios=@Comentarios, IdUsuario=@IdUsuario WHERE Id=@Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", venta.id);
                        command.Parameters.AddWithValue("@Comentarios", venta.comentarios);
                        command.Parameters.AddWithValue("@IdUsuario", venta.idUsuario);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }
        }

        public static void DeleteVenta(int id)
        {
            string deleteQuery = "DELETE FROM Venta WHERE Id=@Id";

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
