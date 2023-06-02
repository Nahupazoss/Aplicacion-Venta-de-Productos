using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pazos
{
    public class Validacion
    {
        public static bool ValidarTexto(string dato)
        {
            return !string.IsNullOrEmpty(dato);
        }

        public static bool ValidarNum(int num)
        {
            return !string.IsNullOrEmpty(Convert.ToString(num));
        }

        public static bool ValidarNumFloat(float num)
        {
            return !string.IsNullOrEmpty(Convert.ToString(num));
        }

        public static bool ValidarCliente(string nombre, int telefono, string correo)
        {
            return Validacion.ValidarTexto(nombre) && Validacion.ValidarNum(telefono) && Validacion.ValidarTexto(correo);
        }

        public static bool ValidarProducto(string nombre, float precio, string categoria)
        {
            return Validacion.ValidarTexto(nombre) && Validacion.ValidarNumFloat(precio) && Validacion.ValidarTexto(categoria);
        }
    }
}
