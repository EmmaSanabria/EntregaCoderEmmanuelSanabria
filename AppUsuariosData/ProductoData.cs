using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppUsuariosEntities;

namespace AppUsuariosData
{
    public static class ProductoData
    {
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
                        using(SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    Producto producto = new Producto();

                                    producto.id = Convert.ToInt32(dr["Id"]);
                                    producto.descripcion = dr["Descripcion"].ToString();
                                    producto.costo = Convert.ToDouble(dr["Costo"]);
                                    producto.precioVenta = Convert.ToDouble(dr["PrecioVenta"]);
                                    producto.stock = Convert.ToInt32(dr["Stock"]);
                                    producto.idUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    listaProducto.Add(producto);
                                }
                            }
                            return listaProducto;
                        }
                    }
                    connexion.Close();
                }
            }
            catch (Exception ex)
            {
                return listaProducto;
            }
        }
    }
}
