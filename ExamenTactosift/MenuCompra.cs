using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenTactosift;
using Pazos;

namespace ExamenTacticasoft
{
    public partial class MenuCompra : Form
    {
        BaseDatosProducto accesoDatosProducto;
        List<Producto> productos;
        FormInicio menuInicio;
        public MenuCompra()
        {
            InitializeComponent();
        }

        private void MenuCompra_Load(object sender, EventArgs e)
        {
            menuInicio = new FormInicio();
            accesoDatosProducto = new BaseDatosProducto();
            productos = new List<Producto>();
            ActualizarDataGrid();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = (Producto)dtgv_ProductosVenta.SelectedRows[0].DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(respuesta == DialogResult.Yes)
            {
                
            }
        }

        private void ActualizarDataGrid()
        {
            this.dtgv_ProductosVenta.DataSource = null;
            productos =accesoDatosProducto.ObtenerListaProducto();
            this.dtgv_ProductosVenta.DataSource = productos;
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            Hide();
            menuInicio.Show();
        }
    }
}
