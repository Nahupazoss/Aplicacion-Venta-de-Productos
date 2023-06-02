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
    public partial class FormModificarProducto : Form
    {
        Producto productoSeleccionado;
        BaseDatosProducto accesoDatosProducto;
        public FormModificarProducto(Producto producto)
        {
            InitializeComponent();
            this.productoSeleccionado = producto;
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_AgregarPRD_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txt_nombrePRD.ToString();
            float nuevoPrecio = float.Parse(txt_PrecioPRD.ToString());
            string nuevaCategoria = txt_CategoriaPRD.ToString();

            if(Validacion.ValidarProducto(nuevoNombre, nuevoPrecio, nuevaCategoria))
            {
                productoSeleccionado.Nombre = nuevoNombre;
                productoSeleccionado.Precio = nuevoPrecio;
                productoSeleccionado.Categoria = nuevaCategoria;
                accesoDatosProducto.ModificarProducto(productoSeleccionado);
                LimpiarTxtBox();
                Hide();
            }
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {
            accesoDatosProducto = new BaseDatosProducto();
        }

        private void LimpiarTxtBox()
        {
            txt_nombrePRD.Text = "";
            txt_PrecioPRD.Text = "";
            txt_CategoriaPRD.Text = "";
        }
    }
}
