using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppUsuariosEntities;
using PrimeraPreEntrega;

namespace AppUsuariosData
{
    public static class UsuariosData
    {
        public static List<Usuarios> GetUsuario()
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            List<Usuarios> listaUsuarios = new List<Usuarios>();

            string query = "SELECT * FROM Usuarios";
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Usuarios usuario = new Usuarios();
                                    usuario.id = Convert.ToInt32(reader["ID"]);
                                    usuario.nombre = reader["NOMBRE"].ToString();
                                    usuario.apellido = reader["APELLIDO"].ToString();
                                    usuario.nombreUsuario = reader["NOMBREUSUARIO"].ToString();
                                    usuario.contraseña = reader["CONTRASEÑA"].ToString();
                                    usuario.mail = reader["MAIL"].ToString();
                                    listaUsuarios.Add(usuario);
                                }
                            }
                            return listaUsuarios;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                return listaUsuarios;
            }
        }
    }
}