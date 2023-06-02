using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pazos;

namespace ExamenTacticasoft
{
    public partial class FormModificarCliente : Form
    {
        FormClientes menuClientes;
        Cliente clienteSeleccionado;
        BaseDeDatos accesoDatosCliente;
        public FormModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.clienteSeleccionado = cliente;
        }

        private void FormModificarCliente_Load(object sender, EventArgs e)
        {
            menuClientes = new FormClientes();
            accesoDatosCliente = new BaseDeDatos();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Hide();
            menuClientes.Show();
        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txt_nombre.ToString();
            int nuevoTelefono = int.Parse(txt_telefono.ToString());
            string nuevoCorreo = txt_correo.ToString();

            if (Validacion.ValidarCliente(nuevoNombre, nuevoTelefono, nuevoCorreo))
            {
                clienteSeleccionado.Nombre = nuevoNombre;
                clienteSeleccionado.Telefono = nuevoTelefono;
                clienteSeleccionado.Correo = nuevoCorreo;
                accesoDatosCliente.ModificarCliente(clienteSeleccionado);
                LimpiarTxtBox();
                Hide();
            }
        }
        private void LimpiarTxtBox()
        {
            txt_nombre.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
        }
    }
}
