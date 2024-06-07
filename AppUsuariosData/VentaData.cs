using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppUsuariosEntities;  

namespace AppUsuariosData
{
    public static class VentaData
    {
        public static List<Venta> GetVenta()
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            List<Venta> listaVenta = new List<Venta>();

            string query = "SELECT * FROM Venta";
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
                                    Venta venta = new Venta();
                                    venta.id = Convert.ToInt32(reader["ID"]);
                                    venta.comentarios = reader["COMENTARIOS"].ToString();
                                    venta.idUsuario = Convert.ToInt32(reader["ID_USUARIO"]);
                                    listaVenta.Add(venta);
                                }
                            }
                            return listaVenta;
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                return listaVenta;
            }
        }
    }
}
