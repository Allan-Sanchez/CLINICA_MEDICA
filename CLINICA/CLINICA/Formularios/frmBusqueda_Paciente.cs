using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICA.Formularios
{
    public partial class frmBusqueda_Paciente : Form
    {
        private int id_paciente;

        public int Id_paciente
        {
            get { return id_paciente; }
            set { id_paciente = value; }
        }

        public frmBusqueda_Paciente()
        {
            InitializeComponent();
        }

        private void frmBusqueda_Paciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.mEDICODataSet.Pacientes);

        }

        private void fillByid_PacienteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacientesTableAdapter.FillByid_Paciente(this.mEDICODataSet.Pacientes, ((int)(System.Convert.ChangeType(id_PacienteToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBynombresToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacientesTableAdapter.FillBynombres(this.mEDICODataSet.Pacientes, nombresToolStripTextBox.Text+"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByapellidosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacientesTableAdapter.FillByapellidos(this.mEDICODataSet.Pacientes, apellidosToolStripTextBox.Text+"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {


            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.mEDICODataSet.Pacientes);
            nombresToolStripTextBox.Text = "";
            apellidosToolStripTextBox.Text = "";
            id_PacienteToolStripTextBox.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id_paciente = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count>0)
            {
                id_paciente =Convert.ToInt32(dgvPacientes.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                id_paciente =Convert.ToInt32(dgvPacientes.Rows[0].Cells[0].Value);
            }
            this.Close();
        }
    }
}
