using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pazos
{
    public class Producto
    {
        private int id;
        private string nombre;
        private float precio;
        private string categoria;
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

        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public string Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }

        public Producto(int id, string nombre, float precio, string categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
        }

        public Producto( string nombre, float precio, string categoria)
        {
            this.id = 0;
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
        }

        public Producto()
        {
            this.id = 0;
            this.nombre = "";
            this.precio = 0;
            this.categoria = "";
        }
    }
}
