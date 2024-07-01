using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class Producto
        {
            // Atributos
            private int id;
            private string descripcion;
            private double costo;
            private double precioVenta;
            private int stock;
            private int idUsuario;

            // Constructor
            // Default
            public Producto()
            {
                id = 0;
                descripcion = string.Empty;
                costo = 0;
                precioVenta = 0;
                stock = 0;
                idUsuario = 0;
            }

            // Alternativo
            public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
            {
                this.id = id;
                this.descripcion = descripcion;
                this.costo = costo;
                this.precioVenta = precioVenta;
                this.stock = stock;
                this.idUsuario = idUsuario;
            }

            // Getters & Setters
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Descripcion
            {
                get { return descripcion; }
                set { descripcion = value; }
            }

            public double Costo
            {
                get { return costo; }
                set { costo = value; }
            }

            public double PrecioVenta
            {
                get { return precioVenta; }
                set { precioVenta = value; }
            }

            public int Stock
            {
                get { return stock; }
                set { stock = value; }
            }

            public int IdUsuario
            {
                get { return idUsuario; }
                set { idUsuario = value; }
            }
        }
    }

