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
using ExamenTacticasoft;

namespace ExamenTactosift
{
    public partial class FormInicio : Form
    {
        MenuCompra menuDeCompra;
        OpcionesAdmin menuAdmin;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuDeCompra = new MenuCompra();
            menuAdmin = new OpcionesAdmin();
        }

        private void comenzar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            int telefono = Convert.ToInt32(txt_telefono.Text);
            string correo = txt_correo.Text;
            
            if(Validacion.ValidarCliente(nombre, telefono, correo))
            {
                Manejadora.RegistrarCliente(nombre, telefono, correo);
                MessageBox.Show($"{nombre} se ha registrado como un nuevo cliente", "Listo para comprar?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menuDeCompra.Show();
                Hide();
                
            }
            else
            {
                //lbl_msjError.Visible = true;
                MessageBox.Show("Verifique que tiene todos los datos bien ingresados");
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            int telefono = int.Parse(txt_telefono.Text);
            string correo = txt_correo.Text;

            if(Validacion.ValidarTexto(nombre) && Validacion.ValidarNum(telefono) && Validacion.ValidarTexto(correo))
            {
                if (nombre == "admin" && telefono == 0 && correo == "admin")
                {
                    Hide();
                    menuAdmin.Show();
                }
                else
                {
                    MessageBox.Show("No eres administrador");
                }
            }
            else
            {
                MessageBox.Show("Ingresar todos los Datos");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de la Aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre:admin - Telefono:0 - Correo:admin", "DATOS PARA INGRESAR COMO ADMIN");
        }
    }
}

