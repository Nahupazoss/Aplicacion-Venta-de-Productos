using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pazos
{
    public class Venta
    {
        private int id;
        private Cliente IDcliente;
        private DateTime fecha;
        private float total;

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
        public Cliente Cliente
        {
            get
            {
                return this.IDcliente;
            }
            set
            {
                this.IDcliente = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }
        public float Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }

        public Venta(int id, Cliente iDcliente, DateTime fecha, float total)
        {
            this.id = id;
            IDcliente = iDcliente;
            this.fecha = fecha;
            this.total = total;
        }

        public Venta()
        {
            this.id = 0;
            IDcliente = new Cliente();
            this.fecha = DateTime.Now;
            this.total = 0;
        }
    }
}
