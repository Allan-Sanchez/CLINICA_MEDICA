using CLINICA.Clases;
using CLINICA.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICA
{
    public partial class frmPrincipal : Form
    {
        private Usuarios usuarilogiado;

        internal Usuarios Usuarilogiado
        {
            get { return usuarilogiado; }
            set { usuarilogiado = value; }
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void examensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExamenes miExamen = new frmExamenes();

            miExamen.MdiParent = this;
            miExamen.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicos miMedico = new frmMedicos();
            miMedico.MdiParent = this;
            miMedico.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes miPaciente = new frmPacientes();
            miPaciente.MdiParent = this;
          
            miPaciente.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tssbUsuario_Log.Text = usuarilogiado.nombre + " " + usuarilogiado.apellido;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios miUsuario = new frmUsuarios();
            miUsuario.MdiParent = this;

            miUsuario.Show();
        }

       
    }
}
