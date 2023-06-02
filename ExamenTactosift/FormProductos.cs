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
    public partial class FormProductos : Form
    {
        FormAgregarProductocs agregarProducto;
        FormModificarProducto modificarProducto;
        BaseDatosProducto accesoDatosProducto;
        List<Producto> productos;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            agregarProducto.Show();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            agregarProducto = new FormAgregarProductocs();
            accesoDatosProducto = new BaseDatosProducto();
            productos = new List<Producto>();
            ActualizarDataGrid();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Producto produtoSeleccionado = (Producto)dtgv_productos.SelectedRows[0].DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea modificar el producto?", "Modificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(respuesta == DialogResult.Yes)
            {
                modificarProducto = new FormModificarProducto(produtoSeleccionado);
                modificarProducto.Show();
            }
        }

        private void dtgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarDataGrid()
        {
            this.dtgv_productos.DataSource = null;
            productos = accesoDatosProducto.ObtenerListaProducto();
            this.dtgv_productos.DataSource = productos;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto produtoSeleccionado = (Producto)dtgv_productos.SelectedRows[0].DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Estas seguro que desea eliminar el producto?", "Modificacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    accesoDatosProducto.EliminarDato(produtoSeleccionado.Id);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No seleccionaste ningun producto", "!!!!");
            }
        }
    }
}
