using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlSSPE.Negocio;
using controlSSPE.Entidades;

namespace controlSSPE.Formas
{
    public partial class frmRegitro : Form
    {
        public frmRegitro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            EntidadUsuario user = new EntidadUsuario();
            user.Id = 5;
            user.Nombre = txtName.Text;
            user.Apellidos = txtLastName.Text;
            user.Correo = txtEmail.Text;
            user.Contraseña = txtPassword.Text;
            new Usuarios().Registro(user);
        }
    }
}
