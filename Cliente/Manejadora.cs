using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pazos
{
    public class Manejadora
    {
        static Cliente clienteLoegueado;
        static List<Cliente> clientes;
        static List<Producto> productos;
        static List<Venta> ventas;
        static BaseDeDatos accesoDatosCliente;
        static BaseDatosProducto accesoDatosProductos;

        public static Cliente ClienteLoegueado { get => clienteLoegueado; set => clienteLoegueado = value; }
        public static List<Cliente> Clientes { get => clientes; }

        static Manejadora()
        {
            accesoDatosCliente = new BaseDeDatos();
            accesoDatosProductos = new BaseDatosProducto();
            clientes = accesoDatosCliente.ObtenerListaCliente();
            productos = accesoDatosProductos.ObtenerListaProducto();
            ventas = new List<Venta>();
        }

        public static void RegistrarCliente(string nombre, int telefono, string correo)
        {
            Cliente cliente = new Cliente(nombre, telefono, correo);
            accesoDatosCliente.AgregarCliente(cliente);
        }
        public static void RegistrarProducto(string nombre, float precio, string categoria)
        {
            Producto producto = new Producto(nombre, precio, categoria);
            accesoDatosProductos.AgregarProducto(producto);
        }

        public static List<Cliente> ObtenerClientes()
        {
            clientes = accesoDatosCliente.ObtenerListaCliente();
            return clientes;
        }

        public static List<Producto> ObtenerProducto()
        {
            productos = accesoDatosProductos.ObtenerListaProducto();
            return productos;
        }

        public static bool LoguearCliente(string nombre,int telefono ,string correo)
        {
            bool resultado = false;

            foreach (Cliente item in clientes)
            {
                if (item.Correo == correo)
                {
                    resultado = item.CheckearCorreo(correo);
                    Manejadora.clienteLoegueado = item;
                }
            }
            return resultado;
        }

    }


}
