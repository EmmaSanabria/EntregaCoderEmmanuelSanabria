﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

        public class Venta
        {
            private int Id;
            private string Comentarios;
            private int IdUsuario;

            public Venta() { }

            public Venta(int id, string comentarios, int idUsuario)
            {
                this.Id = id;
                this.Comentarios = comentarios;
                this.IdUsuario = idUsuario;
            }

            public int id
            {
                get { return this.Id; }
                set { this.Id = value; }
            }

            public string comentarios
            {
                get { return this.Comentarios; }
                set { this.Comentarios = value; }
            }

            public int idUsuario
            {
                get { return this.IdUsuario; }
                set { this.IdUsuario = value; }
            }
        }
    }
