using ConsoleApp1;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(String[] args)
        {
            string urlUsuarios = @"https://localhost:7015/api/Usuarios";
            string urlProducto = @"https://localhost:7015/api/Producto";
            string urlProductosVendidos = @"https://localhost:7015/api/ProductosVendidos";
            string urlVenta = @"https://localhost:7015/api/Venta";

            ConsumoApi clientHttpUsuarios = new ConsumoApi(urlUsuarios);
            ConsumoApi clientHttpProducto = new ConsumoApi(urlProducto);
            ConsumoApi clientHttpProductosVendidos = new ConsumoApi(urlProductosVendidos);
            ConsumoApi clientHttpVenta = new ConsumoApi(urlVenta);

            //Usuario
            List<Usuarios> usuarios = await clientHttpUsuarios.ListarUsuarioAsync();

            foreach (Usuarios usuario in usuarios)
            {
                Console.WriteLine($"Usuario: {usuario.nombre}");
            }
            Console.WriteLine("----------------------Modificar-------------------");

            Usuarios usuario1 = new Usuarios();
            usuario1.id = 6;
            usuario1.nombre = "modificado";
            usuario1.apellido = "Sanabria";
            usuario1.nombreUsuario = "Shiros";
            usuario1.contraseña = "jojojo";
            usuario1.mail = "J@gmail.com";

            bool respuesta = await clientHttpUsuarios.ModificarUsuario(usuario1);

            Console.WriteLine(respuesta);

            Console.WriteLine("----------------------Crear-------------------");
            Usuarios usuarioNuevo = new Usuarios();
            usuarioNuevo.nombre = "Pedro Pedro Pe";
            usuarioNuevo.apellido = "Sanabria";
            usuarioNuevo.nombreUsuario = "Shiros";
            usuarioNuevo.contraseña = "jojojo";
            usuarioNuevo.mail = "J@gmail.com";

            bool respuestacrear = await clientHttpUsuarios.CrearUsuario(usuarioNuevo);
            Console.WriteLine(respuestacrear);


            Console.WriteLine("----------------------Eliminar-------------------");

            bool respuestaeliminar = await clientHttpUsuarios.EliminarUsuario(3);
            Console.WriteLine(respuestaeliminar);

            //Producto
            List<Producto> producto = await clientHttpProducto.ListarProductoAsync();

            foreach (Producto productos in producto)
            {
                Console.WriteLine($"Producto: {productos.Descripcion}");
            }
            Console.WriteLine("----------------------Modificar Producto-------------------");

            Producto producto1 = new Producto();
            producto1.Id = 6;
            producto1.Descripcion = "Pedro Pedro Pe";
            producto1.Costo = 1;
            producto1.PrecioVenta = 10;
            producto1.Stock = 1;
            producto1.IdUsuario = 2;

            bool respuestaModificarProducto = await clientHttpProducto.ModificarProducto(producto1);

            Console.WriteLine(respuestaModificarProducto);

            Console.WriteLine("----------------------Crear Producto-------------------");
            Producto productoNuevo = new Producto();
            productoNuevo.Descripcion = "Pedro Pedro Pe";
            productoNuevo.Costo = 1;
            productoNuevo.PrecioVenta = 10;
            productoNuevo.Stock = 1;
            productoNuevo.IdUsuario = 2;

            bool respuestacrearproducto = await clientHttpProducto.CrearProducto(productoNuevo);
            Console.WriteLine(respuestacrearproducto);


            Console.WriteLine("----------------------Eliminar Producto-------------------");

            bool respuestaeliminarproducto = await clientHttpProducto.EliminarProducto(8);
            Console.WriteLine(respuestaeliminarproducto);


            //ProductoVendido
            List<ProductosVendidos> productovendido = await clientHttpProductosVendidos.ListarProductosVendidosAsync();

            foreach (ProductosVendidos productosvendido in productovendido)
            {
                Console.WriteLine($"ProductoVendido: {productosvendido.Stock}");
            }
            Console.WriteLine("----------------------Modificar ProductoVendido-------------------");

            ProductosVendidos productosVendidos1 = new ProductosVendidos();
            productosVendidos1.Id = 2;
            productosVendidos1.IdProducto = 5;
            productosVendidos1.Stock = 10000;
            productosVendidos1.IdVenta = 74;

            bool respuestaModificarProductoVendidos = await clientHttpProductosVendidos.ModificarProductosVendidos(productosVendidos1);

            Console.WriteLine(respuestaModificarProductoVendidos);

            Console.WriteLine("----------------------Crear ProductoVendido-------------------");
            ProductosVendidos productosVendidos = new ProductosVendidos();
            productosVendidos.IdProducto = 2;
            productosVendidos.Stock = 10340;
            productosVendidos.IdVenta = 4;

            bool respuestacrearProductoVendidos = await clientHttpProductosVendidos.CrearProductosVendidos(productosVendidos);
            Console.WriteLine(respuestacrearProductoVendidos);


            Console.WriteLine("----------------------Eliminar ProductoVendido-------------------");

            bool respuestaeliminarProductoVendidos = await clientHttpProductosVendidos.EliminarProductosVendidos(8);
            Console.WriteLine(respuestaeliminarProductoVendidos);

            //Venta
            List<Venta> venta = await clientHttpVenta.ListarVentaAsync();

            foreach (Venta ventas in venta)
            {
                Console.WriteLine($"Comentarios Venta: {ventas.comentarios}");
            }
            Console.WriteLine("----------------------Modificar Venta-------------------");

            Venta venta1 = new Venta();
            venta1.id = 3;
            venta1.comentarios = "excelente producto";
            venta1.idUsuario = 2;

            bool respuestaModificarVenta = await clientHttpVenta.ModificarVenta(venta1);

            Console.WriteLine(respuestaModificarVenta);

            Console.WriteLine("----------------------Crear Venta-------------------");
            Venta ventaNueva = new Venta();
            ventaNueva.comentarios = "Pesimo producto";
            ventaNueva.idUsuario = 3;

            bool respuestacrearVenta = await clientHttpVenta.CrearVenta(ventaNueva);
            Console.WriteLine(respuestacrearVenta);


            Console.WriteLine("----------------------Eliminar Venta-------------------");

            bool respuestaeliminarVenta = await clientHttpVenta.EliminarVenta(8);
            Console.WriteLine(respuestaeliminarVenta);



        }
    }
}
