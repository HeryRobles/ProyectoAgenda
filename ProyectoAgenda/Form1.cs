using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto contacto = new Contacto(); 
                contacto.Nombre = txtNombre.Text;
                contacto.Email = txtEmail.Text; 
                contacto.Telefono = txtTelefono.Text;   
                contacto.Activo = ChkBoxActivo.Checked;
                contacto.AgregarContacto();
                MessageBox.Show("Contacto Agregado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
