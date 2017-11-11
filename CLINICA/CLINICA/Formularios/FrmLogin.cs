using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLINICA.Clases;

namespace CLINICA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Error");
                txtUsuario.Focus();
            }
            if (txtPassword.Text=="")
            {
                MessageBox.Show("Debe ingresar un contraseña ", "Error");
                txtPassword.Focus();
            }

            if (!Usuario.Validar_Usuario(txtUsuario.Text,txtPassword.Text))
            {
                MessageBox.Show(Usuario.Mensaje,"Error");
                txtUsuario.Focus();
                return;
            }

            frmPrincipal principal = new frmPrincipal();
            this.Hide();//ocultar el formulario del login
            principal.Show();
            

        }

        
        
    }
}
