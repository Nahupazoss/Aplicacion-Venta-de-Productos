using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pazos
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private int telefono;
        private string correo;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }
        public string Correo
        {
            get
            {
                return this.correo;
            }
            set
            {
                this.correo = value;
            }
        }

        public Cliente(int id, string nombre, int telefono, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }

        public Cliente(string nombre, int telefono, string correo)
        {
            this.id = 0;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }
        public Cliente()
        {
            this.id = 0;
            this.nombre = "";
            this.telefono = 0;
            this.correo = "";
        }

        public bool CheckearCorreo(string correo)
        {
            return correo == this.correo;
        }
    }
}
