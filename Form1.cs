using System;
using System.Windows.Forms;

namespace INICIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string correo = txtcorreo.Text;
            string contra = txtcontra.Text;

          

            // Abrir el formulario de men�
            Menu frmMenu = new Menu();
            frmMenu.Show();

            // Ocultar el formulario actual (registro)
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcorreo.Clear();
            txtcontra.Clear();


            txtnombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
