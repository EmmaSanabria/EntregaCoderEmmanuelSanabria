using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsuariosEntities
{
    public class ProductosVendidos
    {
        private int Id;
        private int IdProducto;
        private int Stock;
        private int IdVenta;

        public ProductosVendidos() { }

        public ProductosVendidos(int id, int idProducto, int stock, int idVenta)
        {
            this.Id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }

        public int id
        {
            get { return Id; }
            set { this.Id = value; }
        }

        public int idProducto
        {
            get { return IdProducto; }
            set { this.IdProducto = value; }
        }

        public int stock
        {
            get { return Stock; }
            set { this.Stock = value; }
        }

        public int idVenta
        {
            get { return IdVenta; }
            set { this.IdVenta = value; }
        }
    }
}