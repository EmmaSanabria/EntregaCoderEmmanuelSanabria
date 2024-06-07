using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsuariosEntities
{
    public class Producto
    {
        //Atributos
        private int Id;
        private string Descripcion;
        private double Costo;
        private double PrecioVenta;
        private int Stock;
        private int IdUsuario;

        //Constructor
        //Default
        public Producto()
        {
            Id = 0;
            Descripcion = string.Empty;
            Costo = 0;
            PrecioVenta = 0;
            Stock = 0;
            IdUsuario = 0;
        }
        //Alternativo
        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsuario = idUsuario;
        }

        //Getter & Setter

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public double costo
        {
            get { return Costo; }
            set { this.Costo = value; }
        }
        public double precioVenta
        {
            get { return PrecioVenta; }
            set { this.PrecioVenta = value; }
        }
        public int stock
        {
            get { return Stock; }
            set { Stock = value; }
        }
        public int idUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
    }
}
