using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConsumoApi
    {
        private readonly HttpClient cliente;
        private readonly string _basePath;

        public ConsumoApi(string basePath)
        {
            cliente = new HttpClient();
            _basePath = basePath;
        }

        //Producto
        //Listar Producto
        public async Task<List<Producto>> ListarProductoAsync()
        {
            List<Producto>? lista_producto = null;
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(_basePath);
                if (response.IsSuccessStatusCode)
                {
                    lista_producto = await response.Content.ReadFromJsonAsync<List<Producto>>();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con la API: " + ex);
            }
            return lista_producto;
        }

        //Modificar Producto
        public async Task<bool> ModificarProducto(Producto producto)
        {
            try
            {
                HttpResponseMessage response = await cliente.PutAsJsonAsync($"{_basePath}/{producto.Id}", producto);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar el Producto: " + ex);
                return false;
            }
        }
        //Crear Producto

        public async Task<bool> CrearProducto(Producto producto)
        {

            try
            {
                HttpResponseMessage response = await cliente.PostAsJsonAsync(_basePath, producto);
                response.EnsureSuccessStatusCode();

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el Producto: " + ex);
                return false;
            }



        }
        //Delete Producto

        public async Task<bool> EliminarProducto(int id)
        {
            try
            {
                HttpResponseMessage response = await cliente.DeleteAsync($"{_basePath}/{id}");
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el Producto: " + ex);
                return false;
            }
        }
        //ProductosVendidos
        //Listar ProductosVendidos
        public async Task<List<ProductosVendidos>> ListarProductosVendidosAsync()
        {
            List<ProductosVendidos>? lista_productoVendidos = null;
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(_basePath);
                if (response.IsSuccessStatusCode)
                {
                    lista_productoVendidos = await response.Content.ReadFromJsonAsync<List<ProductosVendidos>>();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con la API: " + ex);
            }
            return lista_productoVendidos;
        }

        //Modificar ProductosVendidos
        public async Task<bool> ModificarProductosVendidos(ProductosVendidos productoVendido)
        {
            try
            {
                HttpResponseMessage response = await cliente.PutAsJsonAsync($"{_basePath}/{productoVendido.Id}", productoVendido);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar el ProductosVendidos: " + ex);
                return false;
            }
        }
        //Crear ProductosVendidos

        public async Task<bool> CrearProductosVendidos(ProductosVendidos productoVendido)
        {
            HttpResponseMessage response = await cliente.PostAsJsonAsync(_basePath, productoVendido);
            response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;
        }
        //Delete ProductosVendidos

        public async Task<bool> EliminarProductosVendidos(int id)
        {
            try
            {
                HttpResponseMessage response = await cliente.DeleteAsync($"{_basePath}/{id}");
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el ProductosVendidos: " + ex);
                return false;
            }
        }
        //Venta
        //Listar Venta
        public async Task<List<Venta>> ListarVentaAsync()
        {
            List<Venta>? lista_Venta = null;
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(_basePath);
                if (response.IsSuccessStatusCode)
                {
                    lista_Venta = await response.Content.ReadFromJsonAsync<List<Venta>>();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con la API: " + ex);
            }
            return lista_Venta;
        }

        //Modificar Venta
        public async Task<bool> ModificarVenta(Venta venta)
        {
            try
            {
                HttpResponseMessage response = await cliente.PutAsJsonAsync($"{_basePath}/{venta.id}", venta);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar el usuario: " + ex);
                return false;
            }
        }
        //Crear Venta

        public async Task<bool> CrearVenta(Venta venta)
        {
            HttpResponseMessage response = await cliente.PostAsJsonAsync(_basePath, venta);
            response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;
        }
        //Delete Venta

        public async Task<bool> EliminarVenta(int id)
        {
            try
            {
                HttpResponseMessage response = await cliente.DeleteAsync($"{_basePath}/{id}");
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario: " + ex);
                return false;
            }
        }
        //Usuario
        //Listar Usuario
        public async Task<List<Usuarios>> ListarUsuarioAsync()
        {
            List<Usuarios>? lista_usuario = null;
            try
            {
                HttpResponseMessage response = await cliente.GetAsync(_basePath);
                if (response.IsSuccessStatusCode)
                {
                    lista_usuario = await response.Content.ReadFromJsonAsync<List<Usuarios>>();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con la API: " + ex);
            }
            return lista_usuario;
        }
        //Modificar Usuario
        public async Task<bool> ModificarUsuario(Usuarios usuario)
        {
            try
            {
                HttpResponseMessage response = await cliente.PutAsJsonAsync($"{_basePath}/{usuario.id}", usuario);
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar el usuario: " + ex);
                return false;
            }
        }
        //Crear Usuario

        public async Task<bool> CrearUsuario(Usuarios usuario)
        {
            HttpResponseMessage response = await cliente.PostAsJsonAsync(_basePath, usuario);
            response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;
        }
        //Delete Usuario

        public async Task<bool> EliminarUsuario(int id)
        {
            try
            {
                HttpResponseMessage response = await cliente.DeleteAsync($"{_basePath}/{id}");
                response.EnsureSuccessStatusCode();
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el usuario: " + ex);
                return false;
            }
        }

    }
}