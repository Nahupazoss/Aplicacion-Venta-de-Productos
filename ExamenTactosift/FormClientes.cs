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
    public partial class FormClientes : Form
    {
        BaseDeDatos accesoDatosCliente;
        List<Cliente> clientes;
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            accesoDatosCliente = new BaseDeDatos();
            clientes = new List<Cliente>();
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            this.dtgv_clientes.DataSource = null;
            clientes = accesoDatosCliente.ObtenerListaCliente();
            this.dtgv_clientes.DataSource = clientes;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteSeleccionado = (Cliente)dtgv_clientes.SelectedRows[0].DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    accesoDatosCliente.EliminarCliente(clienteSeleccionado.Id);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No seleccionaste ningun producto", "!!!!");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)dtgv_clientes.SelectedRows[0].DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea modificar el cliente?", "Modificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                //modificarProducto = new FormModificarProducto(clienteSeleccionado);
                //modificarProducto.Show();
            }
        }
    }
}
