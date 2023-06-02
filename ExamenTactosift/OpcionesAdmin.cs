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
    public partial class OpcionesAdmin : Form
    {
        FormInicio menuInicio;
        FormProductos menuProductos;
        public OpcionesAdmin()
        {
            InitializeComponent();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Hide();
            menuInicio.Show();
        }

        private void OpcionesAdmin_Load(object sender, EventArgs e)
        {
            menuInicio = new FormInicio();
            menuProductos = new FormProductos();
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btn_verProducto_Click(object sender, EventArgs e)
        {
            Hide();
            menuProductos.Show();         
        }

        private void btn_VerClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
