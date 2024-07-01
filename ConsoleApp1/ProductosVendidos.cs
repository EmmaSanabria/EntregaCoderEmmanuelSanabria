using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class ProductosVendidos
        {
            public int Id { get; set; }
            public int IdProducto { get; set; }
            public int Stock { get; set; }
            public int IdVenta { get; set; }

            public ProductosVendidos() { }

            public ProductosVendidos(int id, int idProducto, int stock, int idVenta)
            {
                Id = id;
                IdProducto = idProducto;
                Stock = stock;
                IdVenta = idVenta;
            }
        }
    }
