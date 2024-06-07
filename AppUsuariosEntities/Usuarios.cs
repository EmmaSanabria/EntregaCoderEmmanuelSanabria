using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraPreEntrega
{
    public class Usuarios
    {
        //Atributos
        private int _Id;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private string _Contraseña;
        private string _Mail;

        //Constructor
        //Default
        public Usuarios()
        {
            _Id = 0;
            _Nombre = string.Empty;
            _Apellido = string.Empty;
            _NombreUsuario = string.Empty;
            _Contraseña = string.Empty;
            _Mail = string.Empty;
        }
        //Alternativo
        public Usuarios(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this._Id = id;
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._NombreUsuario = nombreUsuario;
            this._Contraseña = contraseña;
            this._Mail = mail;
        }
        //Getters & Setters
        public int id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }
        public string nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }

        public string apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }
        public string nombreUsuario
        {
            get { return this._NombreUsuario; }
            set { this._NombreUsuario = value; }
        }
        public string contraseña
        {
            get { return this._Contraseña; }
            set { this._Contraseña = value; }
        }
        public string mail
        {
            get { return this._Mail; }
            set { this._Mail = value; }
        }
    }

}
