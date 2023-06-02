using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pazos
{
    public class VentasItem
    {
        public int id;
        public Venta IDventa;
        public Producto IDproducto;
        public float precioUnitario;
        public int cantidad;
        public float PrecioTotal;

        public VentasItem(int id, Venta iDventa, Producto iDproducto, float precioUnitario, int cantidad, float precioTotal)
        {
            this.id = id;
            IDventa = iDventa;
            IDproducto = iDproducto;
            this.precioUnitario = precioUnitario;
            this.cantidad = cantidad;
            PrecioTotal = precioTotal;
        }
    }
}
