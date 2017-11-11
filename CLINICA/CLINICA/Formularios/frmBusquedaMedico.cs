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
    public partial class frmBusquedaMedico : Form
    {
        private int id_medico;

        public int Id_medico
        {
            get { return id_medico; }
            set { id_medico = value; }
        }


        public frmBusquedaMedico()
        {
            InitializeComponent();
        }

        private void frmBusquedaMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.mEDICODataSet.Medicos);

        }

        private void fillByid_Medico1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.medicosTableAdapter.FillByid_Medico1(this.mEDICODataSet.Medicos, ((int)(System.Convert.ChangeType(id_MedicoToolStripTextBox.Text, typeof(int)))));
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
                this.medicosTableAdapter.FillBynombres(this.mEDICODataSet.Medicos, nombresToolStripTextBox.Text +"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.mEDICODataSet.Medicos);
            nombresToolStripTextBox.Text = "";
            id_MedicoToolStripTextBox.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id_medico = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBusquedaMedico.SelectedRows.Count>0)
            {
                id_medico =Convert.ToInt32(dgvBusquedaMedico.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                id_medico =Convert.ToInt32(dgvBusquedaMedico.Rows[0].Cells[0].Value);
            }

            this.Close();
        }
    }
}
