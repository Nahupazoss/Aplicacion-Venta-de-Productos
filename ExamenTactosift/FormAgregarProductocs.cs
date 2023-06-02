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
    public partial class FormAgregarProductocs : Form
    {
        OpcionesAdmin menuAdmin;
        public FormAgregarProductocs()
        {
            InitializeComponent();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            Hide();
            menuAdmin.Show();
        }

        private void FormAgregarProductocs_Load(object sender, EventArgs e)
        {
            menuAdmin = new OpcionesAdmin();
        }

        private void btn_AgregarPRD_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombrePRD.ToString();
            float precio = float.Parse(txt_PrecioPRD.Text);
            string categoria = txt_CategoriaPRD.ToString();

            if(Validacion.ValidarProducto(nombre,precio,categoria))
            {
                Manejadora.RegistrarProducto(nombre,precio,categoria);
                MessageBox.Show($"{nombre} Se ha agregado correctamente ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo agrgar el producto ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
