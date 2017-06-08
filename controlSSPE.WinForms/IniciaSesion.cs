using System;
using System.Windows.Forms;
using controlSSPE.Negocio;

namespace controlSSPE.Formas
{
    /// <summary>
    /// Clase para firmar al usuario
    /// </summary>
    public partial class frmIniciaSesion : Form
    {
        /// <summary>
        /// Inicializa los componentes
        /// </summary>
        public frmIniciaSesion()
        {
            InitializeComponent();
        }


        private void IniciaSesion_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo para iniciar sesion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            Console.WriteLine(new Usuarios().IniciaSesion(txtUsuario.Text, txtContraseña.Text));
        }

        private void waterMarkTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
