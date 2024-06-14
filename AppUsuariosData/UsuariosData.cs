using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using PrimeraPreEntrega;

namespace AppUsuariosData
{
    public static class UsuariosData
    {
        private static string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";

        public static List<Usuarios> GetUsuarios()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            string query = "SELECT * FROM Usuarios";

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
                                Usuarios usuario = new Usuarios
                                {
                                    id = Convert.ToInt32(dr["Id"]),
                                    nombre = dr["Nombre"].ToString(),
                                    apellido = dr["Apellido"].ToString(),
                                    nombreUsuario = dr["NombreUsuario"].ToString(),
                                    contraseña = dr["Contraseña"].ToString(),
                                    mail = dr["Mail"].ToString()
                                };

                                listaUsuarios.Add(usuario);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }

            return listaUsuarios;
        }

        public static void CreateUsuario(Usuarios usuario)
        {
            string insertQuery = "INSERT INTO Usuarios (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@Nombre", usuario.nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.apellido);
                        command.Parameters.AddWithValue("@NombreUsuario", usuario.nombreUsuario);
                        command.Parameters.AddWithValue("@Contraseña", usuario.contraseña);
                        command.Parameters.AddWithValue("@Mail", usuario.mail);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }
        }

        public static void UpdateUsuario(Usuarios usuario)
        {
            string updateQuery = "UPDATE Usuarios SET Nombre=@Nombre, Apellido=@Apellido, NombreUsuario=@NombreUsuario, Contraseña=@Contraseña, Mail=@Mail WHERE Id=@Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@Id", usuario.id);
                        command.Parameters.AddWithValue("@Nombre", usuario.nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.apellido);
                        command.Parameters.AddWithValue("@NombreUsuario", usuario.nombreUsuario);
                        command.Parameters.AddWithValue("@Contraseña", usuario.contraseña);
                        command.Parameters.AddWithValue("@Mail", usuario.mail);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguear el error)
            }
        }

        public static void DeleteUsuario(int id)
        {
            string deleteQuery = "DELETE FROM Usuarios WHERE Id=@Id";

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
