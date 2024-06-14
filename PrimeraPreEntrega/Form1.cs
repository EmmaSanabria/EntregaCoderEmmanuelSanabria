using AppUsuariosEntities;
using AppUsuariosBussiness;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace PrimeraPreEntrega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Listar los productos al cargar el formulario
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = Listar_Productos();

            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = Listar_Usuarios();

            dgVenta.AutoGenerateColumns = true;
            dgVenta.DataSource = Listar_Ventas();

            dgProductosVendidos.AutoGenerateColumns = true;
            dgProductosVendidos.DataSource = Listar_ProductosVendidos();
        }

        static public List<Producto> Listar_Productos()
        {
            List<Producto> listaProducto = new List<Producto>();
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var query = "SELECT Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario FROM Producto";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var producto = new Producto
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
                }
                conexion.Close();
            }

            return listaProducto;
        }

        public static List<Usuarios> Listar_Usuarios()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            string rutaConeccion = @"Server=localhost; Database=Producto ; Trusted_Connection=True";
            var query = "SELECT ID, NOMBRE, APELLIDO, NOMBREUSUARIO, CONTRASEÑA, MAIL FROM Usuarios";

            using (SqlConnection coneccion = new SqlConnection(rutaConeccion))
            {
                coneccion.Open();
                using (SqlCommand cmd = new SqlCommand(query, coneccion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var usuario = new Usuarios();
                                usuario.id = Convert.ToInt32(reader["ID"]);
                                usuario.nombre = reader["NOMBRE"].ToString();
                                usuario.apellido = reader["APELLIDO"].ToString();
                                usuario.nombreUsuario = reader["NOMBREUSUARIO"].ToString();
                                usuario.contraseña = reader["CONTRASEÑA"].ToString();
                                usuario.mail = reader["MAIL"].ToString();
                                listaUsuarios.Add(usuario);
                            }
                        }
                    }
                }
                coneccion.Close();
                return listaUsuarios;
            }
        }


        public static List<Venta> Listar_Ventas()
        {
            List<Venta> listaVenta = new List<Venta>();
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            string query = "SELECT * FROM Venta";

            using (SqlConnection connection = new SqlConnection(rutaConeccion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var venta = new Venta();
                                venta.id = Convert.ToInt32(reader["Id"]);
                                venta.comentarios = reader["Comentarios"].ToString();
                                venta.idUsuario = Convert.ToInt32(reader["Id_Usuario"]); ;
                                listaVenta.Add(venta);
                            }
                        }
                    }
                }
                connection.Close();
                return listaVenta;
            }

        }


        public static List<ProductosVendidos> Listar_ProductosVendidos()
        {
            List<ProductosVendidos> listaProductosVendidos = new List<ProductosVendidos>();
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            string query = "SELECT * FROM ProductosVendidos";

            using (SqlConnection connection = new SqlConnection(rutaConeccion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var productosVendidos = new ProductosVendidos();
                                productosVendidos.Id = Convert.ToInt32(reader["id"]);
                                productosVendidos.IdProducto = Convert.ToInt32(reader["idProducto"]);
                                productosVendidos.Stock = Convert.ToInt32(reader["stock"]);
                                productosVendidos.IdVenta = Convert.ToInt32(reader["idVenta"]);
                                listaProductosVendidos.Add(productosVendidos);
                            }
                        }
                    }
                }
                connection.Close();
                return listaProductosVendidos;
            }
        }

        static public void Eliminar_Producto(int id)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var deleteQuery = "DELETE FROM Producto WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(deleteQuery, conexion))
                {
                    command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });
                    command.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void Eliminar_Usuario()
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var query = "DELETE FROM Usuarios WHERE ID=@IDUsu";

            double valorId = 1;
            var parametro = new SqlParameter();

            parametro.ParameterName = "@IDUsu";
            parametro.SqlDbType = SqlDbType.BigInt;
            parametro.Value = valorId;

            using (SqlConnection coneccion = new SqlConnection(rutaConeccion))
            {
                coneccion.Open();
                using (SqlCommand commandoDelete = new SqlCommand(query, coneccion))
                {
                    commandoDelete.Parameters.Add(parametro);
                    commandoDelete.ExecuteNonQuery();
                }
                coneccion.Close();
            }
        }

        public static void Eliminar_Venta()
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var query = "DELETE FROM Venta WHERE ID=@IDUsu";

            double valorId = 1;
            var parametro = new SqlParameter();

            parametro.ParameterName = "@IDUsu";
            parametro.SqlDbType = SqlDbType.BigInt;
            parametro.Value = valorId;

            using (SqlConnection coneccion = new SqlConnection(rutaConeccion))
            {
                coneccion.Open();
                using (SqlCommand commandoDelete = new SqlCommand(query, coneccion))
                {
                    commandoDelete.Parameters.Add(parametro);
                    commandoDelete.ExecuteNonQuery();
                }
                coneccion.Close();
            }
        }

        public static void Eliminar_ProductosVendidos()
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var query = "DELETE FROM ProductosVendidos WHERE ID=@IDUsu";

            double valorId = 1;
            var parametro = new SqlParameter();

            parametro.ParameterName = "@IDUsu";
            parametro.SqlDbType = SqlDbType.BigInt;
            parametro.Value = valorId;

            using (SqlConnection coneccion = new SqlConnection(rutaConeccion))
            {
                coneccion.Open();
                using (SqlCommand commandoDelete = new SqlCommand(query, coneccion))
                {
                    commandoDelete.Parameters.Add(parametro);
                    commandoDelete.ExecuteNonQuery();
                }
                coneccion.Close();
            }
        }

        static public void Modificar_Producto(int valorId, string descripcion)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var updateQuery = "UPDATE Producto SET Descripcion=@Descripcion WHERE ID=@IDUsu";
            var parametroId = new SqlParameter();
            var descripcionParametro = new SqlParameter();

            parametroId.ParameterName = "IDUsu";
            parametroId.SqlDbType = SqlDbType.BigInt;
            parametroId.Value = valorId;

            descripcionParametro.ParameterName = "Descripcion";
            descripcionParametro.SqlDbType = SqlDbType.VarChar;
            descripcionParametro.Value = descripcion;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(updateQuery, conexion))
                {
                    command.Parameters.Add(parametroId);
                    command.Parameters.Add(descripcionParametro);
                    command.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void Modificar_Usuario(double valorId, string valorNombre)
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            using (SqlConnection coneccion = new SqlConnection(rutaConeccion))
            {
                var query = "UPDATE Usuarios SET NOMBRE=@nom WHERE ID=@IDUsu";
                var parametroId = new SqlParameter();

                parametroId.ParameterName = "@IDUsu";
                parametroId.SqlDbType = SqlDbType.BigInt;
                parametroId.Value = valorId;

                var parametroNom = new SqlParameter();

                parametroNom.ParameterName = "@nom";
                parametroNom.SqlDbType = SqlDbType.VarChar;
                parametroNom.Value = valorNombre;
                coneccion.Open();
                using (SqlCommand commandUpdate = new SqlCommand(query, coneccion))
                {
                    commandUpdate.Parameters.Add(parametroId);
                    commandUpdate.Parameters.Add(parametroNom);
                    commandUpdate.ExecuteNonQuery();
                }
                coneccion.Close();
            }
        }

        public static void Modificar_Venta(double valorId, string valorComentario)
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            using (SqlConnection coneccion = new SqlConnection(rutaConeccion))
            {
                var query = "UPDATE Venta SET COMENTARIOS=@com WHERE ID=@IDUsu";
                var parametroId = new SqlParameter();

                parametroId.ParameterName = "@IDUsu";
                parametroId.SqlDbType = SqlDbType.BigInt;
                parametroId.Value = valorId;

                var parametroCom = new SqlParameter();

                parametroCom.ParameterName = "@com";
                parametroCom.SqlDbType = SqlDbType.VarChar;
                parametroCom.Value = valorComentario;
                coneccion.Open();
                using (SqlCommand commandUpdate = new SqlCommand(query, coneccion))
                {
                    commandUpdate.Parameters.Add(parametroId);
                    commandUpdate.Parameters.Add(parametroCom);
                    commandUpdate.ExecuteNonQuery();
                }
                coneccion.Close();
            }
        }

        public static void Modificar_ProductosVendidos(double valorId, int valorStock)
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            using (SqlConnection coneccion = new SqlConnection(rutaConeccion))
            {
                var query = "UPDATE ProductosVendidos SET stock=@stock WHERE ID=@IDUsu";
                var parametroId = new SqlParameter();

                parametroId.ParameterName = "@IDUsu";
                parametroId.SqlDbType = SqlDbType.BigInt;
                parametroId.Value = valorId;

                var parametroStock = new SqlParameter();

                parametroStock.ParameterName = "@stock";
                parametroStock.SqlDbType = SqlDbType.BigInt;
                parametroStock.Value = valorStock;
                coneccion.Open();
                using (SqlCommand commandUpdate = new SqlCommand(query, coneccion))
                {
                    commandUpdate.Parameters.Add(parametroId);
                    commandUpdate.Parameters.Add(parametroStock);
                    commandUpdate.ExecuteNonQuery();
                }
                coneccion.Close();
            }
        }

        static public void Agregar_Producto(string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var insertQuery = "INSERT INTO Producto (Descripcion, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, conexion))
                {
                    command.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar) { Value = descripcion });
                    command.Parameters.Add(new SqlParameter("@Costo", SqlDbType.Float) { Value = costo });
                    command.Parameters.Add(new SqlParameter("@PrecioVenta", SqlDbType.Float) { Value = precioVenta });
                    command.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int) { Value = stock });
                    command.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int) { Value = idUsuario });
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Agregar_Usuario(string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var insertQuery = "INSERT INTO Usuarios (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES (@nombre, @apellido, @nombreUsuario, @contraseña, @mail)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, conexion))
                {
                    command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar) { Value = nombre });
                    command.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar) { Value = apellido });
                    command.Parameters.Add(new SqlParameter("@nombreUsuario", SqlDbType.VarChar) { Value = nombreUsuario });
                    command.Parameters.Add(new SqlParameter("@contraseña", SqlDbType.VarChar) { Value = contraseña });
                    command.Parameters.Add(new SqlParameter("@mail", SqlDbType.VarChar) { Value = mail });
                    command.ExecuteNonQuery();
                }
            }
        }

        private void AgregarProducto_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string descripcion = txtDescripcion.Text;
            double costo = Convert.ToDouble(txtCosto.Text);
            double precioVenta = Convert.ToDouble(txtPrecioVenta.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            int idUsuario = Convert.ToInt32(txtIdUsuario.Text);

            // Llamar a la función para agregar un nuevo producto
            Agregar_Producto(descripcion, costo, precioVenta, stock, idUsuario);

            // Actualizar el DataGridView después de agregar el nuevo producto
            dgProductos.DataSource = Listar_Productos();
        }

        public static void Agregar_Venta(string comentarios, int id_Usuario)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var insertQuery = "INSERT INTO Venta (COMENTARIOS, ID_USUARIO) VALUES (@comentarios, @idUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, conexion))
                {
                    command.Parameters.Add(new SqlParameter("@comentarios", SqlDbType.VarChar) { Value = comentarios });
                    command.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int) { Value = id_Usuario });
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<ProductosVendidos> Obtener_ProductosVendidos()
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var query = "SELECT * FROM ProductosVendidos WHERE ID=@IDUsu";
            List<ProductosVendidos> listaProductosVendidos = new List<ProductosVendidos>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutaConeccion))
                {
                    int ValorParametro = 3;
                    SqlParameter parametro = new SqlParameter
                    {
                        ParameterName = "@IDUsu",
                        SqlDbType = SqlDbType.BigInt,
                        Value = ValorParametro
                    };
                    using (SqlCommand comandoObtener = new SqlCommand(query, conexion))
                    {
                        comandoObtener.Parameters.Add(parametro);

                        conexion.Open();
                        Debug.WriteLine("Conexión abierta.");

                        using (SqlDataReader reader = comandoObtener.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Debug.WriteLine("Filas encontradas.");
                                while (reader.Read())
                                {
                                    var productosVendidos = new ProductosVendidos
                                    {
                                        Id = Convert.ToInt32(reader["id"]),
                                        IdProducto = Convert.ToInt32(reader["idProducto"]),
                                        Stock = Convert.ToInt32(reader["stock"]),
                                        IdVenta = Convert.ToInt32(reader["idVenta"])

                                    };
                                    listaProductosVendidos.Add(productosVendidos);
                                    return listaProductosVendidos;
                                }
                            }
                        }
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ocurrió una excepción: " + ex.Message);
            }
            return null; // Retornar null si no se encuentra un usuario
        }

        public static List<Producto> Obtener_Productos()
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var query = "SELECT * FROM Producto WHERE ID=@IDUsu";
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutaConeccion))
                {
                    int ValorParametro = 3;

                    SqlParameter parametro = new SqlParameter
                    {
                        ParameterName = "@IDUsu",
                        SqlDbType = SqlDbType.BigInt,
                        Value = ValorParametro
                    };

                    using (SqlCommand comandoObtener = new SqlCommand(query, conexion))
                    {
                        comandoObtener.Parameters.Add(parametro);

                        conexion.Open();
                        Debug.WriteLine("Conexión abierta.");

                        using (SqlDataReader dr = comandoObtener.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                Debug.WriteLine("Filas encontradas.");
                                while (dr.Read())
                                {
                                    var producto = new Producto
                                    {
                                        Id = Convert.ToInt32(dr["Id"]),
                                        Descripcion = dr["Descripcion"].ToString(),
                                        Costo = Convert.ToDouble(dr["Costo"]),
                                        PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]),
                                        Stock = Convert.ToInt32(dr["Stock"]),
                                        IdUsuario = Convert.ToInt32(dr["IdUsuario"])
                                    };
                                    listaProductos.Add(producto);
                                    return listaProductos;
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ocurrió una excepción: " + ex.Message);
            }

            return null; // Retornar null si no se encuentra un usuario
        }

        public static List<Usuarios> Obtener_Usuario()
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var query = "SELECT * FROM Usuarios WHERE ID=@IDUsu";
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutaConeccion))
                {
                    int ValorParametro = 3;

                    SqlParameter parametro = new SqlParameter
                    {
                        ParameterName = "@IDUsu",
                        SqlDbType = SqlDbType.BigInt,
                        Value = ValorParametro
                    };

                    using (SqlCommand comandoObtener = new SqlCommand(query, conexion))
                    {
                        comandoObtener.Parameters.Add(parametro);

                        conexion.Open();
                        Debug.WriteLine("Conexión abierta.");

                        using (SqlDataReader reader = comandoObtener.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Debug.WriteLine("Filas encontradas.");
                                while (reader.Read())
                                {
                                    var usuario = new Usuarios
                                    {
                                        id = Convert.ToInt32(reader["ID"]),
                                        nombre = reader["NOMBRE"].ToString(),
                                        apellido = reader["APELLIDO"].ToString(),
                                        nombreUsuario = reader["NOMBREUSUARIO"].ToString(),
                                        contraseña = reader["CONTRASEÑA"].ToString(),
                                        mail = reader["MAIL"].ToString()

                                    };
                                    listaUsuarios.Add(usuario);
                                    return listaUsuarios;
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ocurrió una excepción: " + ex.Message);
            }

            return null; // Retornar null si no se encuentra un usuario
        }

        public static List<Venta> Obtener_Venta()
        {
            string rutaConeccion = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var query = "SELECT * FROM Venta WHERE ID=@IDUsu";
            List<Venta> listaventa = new List<Venta>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(rutaConeccion))
                {
                    int ValorParametro = 3;

                    SqlParameter parametro = new SqlParameter
                    {
                        ParameterName = "@IDUsu",
                        SqlDbType = SqlDbType.BigInt,
                        Value = ValorParametro
                    };

                    using (SqlCommand comandoObtener = new SqlCommand(query, conexion))
                    {
                        comandoObtener.Parameters.Add(parametro);

                        conexion.Open();
                        Debug.WriteLine("Conexión abierta.");

                        using (SqlDataReader reader = comandoObtener.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Debug.WriteLine("Filas encontradas.");
                                while (reader.Read())
                                {
                                    var venta = new Venta
                                    {
                                        id = Convert.ToInt32(reader["Id"]),
                                        comentarios = reader["COMENTARIOS"].ToString(),
                                        idUsuario = Convert.ToInt32(reader["ID_USUARIO"]),

                                    };
                                    listaventa.Add(venta);
                                    return listaventa;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ocurrió una excepción: " + ex.Message);
            }
            return null; // Retornar null si no se encuentra un usuario
        }

        private void ModificarProducto_Click(object sender, EventArgs e)
        {
            string descripcion = "Hola";

            // Llamar a la función para modificar el producto
            Modificar_Producto(1, descripcion);

            // Actualizar el DataGridView después de modificar el producto
            dgProductos.DataSource = Listar_Productos();
        }


        private void dgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgProductos.Rows[e.RowIndex];
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtCosto.Text = row.Cells["Costo"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["PrecioVenta"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                txtIdUsuario.Text = row.Cells["IdUsuario"].Value.ToString();
            }
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgUsuarios.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["_Nombre"].Value.ToString();
                txtApellidoUsuario.Text = row.Cells["_Apellido"].Value.ToString();
                txtNombreUsuario.Text = row.Cells["_NombreUsuario"].Value.ToString();
                txtContraseñaUsuario.Text = row.Cells["_Contraseña"].Value.ToString();
                txtMailUsuario.Text = row.Cells["_Mail"].Value.ToString();

            }
        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            // Obtener los datos del usuario de los campos de texto
            string nombre = txtNombre.Text;
            string apellido = txtApellidoUsuario.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseñaUsuario.Text;
            string mail = txtMailUsuario.Text;

            // Llamar a la función para agregar un nuevo producto
            Agregar_Usuario(nombre, apellido, nombreUsuario, contraseña, mail);

            // Actualizar el DataGridView después de agregar el nuevo producto
            dgUsuarios.DataSource = Listar_Usuarios();
        }

        public static void Agregar_ProductosVendidos(int idProducto, int stock, int idVenta)
        {
            string connectionString = @"Server=localhost; Database=Producto; Trusted_Connection=True";
            var insertQuery = "INSERT INTO ProductosVendidos (idProducto, stock, idVenta) VALUES (@idProducto, @stock, @idVenta)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(insertQuery, conexion))
                {
                    command.Parameters.Add(new SqlParameter("@idProducto", SqlDbType.Int) { Value = idProducto });
                    command.Parameters.Add(new SqlParameter("@stock", SqlDbType.Int) { Value = stock });
                    command.Parameters.Add(new SqlParameter("@idVenta", SqlDbType.Int) { Value = idVenta });
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ModificarUsuario_Click(object sender, EventArgs e)
        {
            Modificar_Usuario(2, "Pedro");
            dgUsuarios.DataSource = Listar_Usuarios();
        }

        private void BorrarUsuario_Click(object sender, EventArgs e)
        {
            Eliminar_Usuario();
            dgUsuarios.DataSource = Listar_Usuarios();
        }

        private void ObtenerUsuario_Click(object sender, EventArgs e)
        {
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = Obtener_Usuario();
        }


        private void dgVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgVenta.Rows[e.RowIndex];
                txtComentarioVenta.Text = row.Cells["Comentario"].Value.ToString();
                txtIdUsuarioVenta.Text = row.Cells["IdUsuario"].Value.ToString();
            }
        }

        private void ObtenerVenta_Click(object sender, EventArgs e)
        {
            dgVenta.AutoGenerateColumns = true;
            dgVenta.DataSource = Obtener_Venta();
        }

        private void BorrarVenta_Click(object sender, EventArgs e)
        {
            Eliminar_Venta();
            dgVenta.DataSource = Listar_Ventas();
        }

        private void ModificarVenta_Click(object sender, EventArgs e)
        {
            Modificar_Venta(2, "Pedropedio");
            dgVenta.DataSource = Listar_Ventas();
        }

        private void AgregarVenta_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            string comentario = txtComentarioVenta.Text;
            int idUsuario = Convert.ToInt32(txtIdUsuarioVenta.Text);


            // Llamar a la función para agregar un nuevo producto
            Agregar_Venta(comentario, idUsuario);

            // Actualizar el DataGridView después de agregar el nuevo producto
            dgVenta.DataSource = Listar_Ventas();
        }

        private void AgregarProductosVendidos_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto
            int idProducto = Convert.ToInt32(txtIdProductoVenta.Text);
            int stock = Convert.ToInt32(txtStockProductoVendido.Text);
            int idVenta = Convert.ToInt32(txtIdVentaProductoVenta.Text);


            // Llamar a la función para agregar un nuevo producto
            Agregar_ProductosVendidos(idProducto, stock, idVenta);

            // Actualizar el DataGridView después de agregar el nuevo producto
            dgProductosVendidos.DataSource = Listar_ProductosVendidos();
        }

        private void ModificarProductosVendidos_Click(object sender, EventArgs e)
        {
            Modificar_ProductosVendidos(2, 4000);
            dgProductosVendidos.DataSource = Listar_ProductosVendidos();
        }

        private void BorrarProductosVendidos_Click(object sender, EventArgs e)
        {
            Eliminar_ProductosVendidos();
            dgProductosVendidos.DataSource = Listar_ProductosVendidos();
        }

        private void ObtenerProductosVendidos_Click(object sender, EventArgs e)
        {
            dgProductosVendidos.AutoGenerateColumns = true;
            dgProductosVendidos.DataSource = Obtener_ProductosVendidos();
        }

        private void dgProductosVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgProductosVendidos.Rows[e.RowIndex];
                txtIdProductoVenta.Text = row.Cells["idProducto"].Value.ToString();
                txtStockProductoVendido.Text = row.Cells["stock"].Value.ToString();
                txtIdVentaProductoVenta.Text = row.Cells["idVenta"].Value.ToString();
            }
        }

        private void BorrarProducto_Click_1(object sender, EventArgs e)
        {
            Eliminar_Producto(2);
            dgProductos.DataSource = Listar_Productos();
        }

        private void ObtenerProducto_Click_1(object sender, EventArgs e)
        {
            dgProductos.AutoGenerateColumns = true;
            dgProductos.DataSource = Obtener_Productos();
        }
    }
}

