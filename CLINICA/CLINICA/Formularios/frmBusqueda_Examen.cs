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
    public partial class frmBusqueda_Examen : Form
    {
        private int id_examen;   

        public int Id_examen
        {
            get { return id_examen; }
        }
        public frmBusqueda_Examen()
        {
            InitializeComponent();
        }


        private void examenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examenesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.mEDICODataSet);

        }

        private void frmBusqueda_Examen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Examenes' Puede moverla o quitarla según sea necesario.
            this.examenesTableAdapter.Fill(this.mEDICODataSet.Examenes);

        }

        private void fillByid_ExamenesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.examenesTableAdapter.FillByid_Examenes(this.mEDICODataSet.Examenes, ((int)(System.Convert.ChangeType(id_ExamenesToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBynombre_ExamenToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.examenesTableAdapter.FillBynombre_Examen(this.mEDICODataSet.Examenes, nombre_ExamenToolStripTextBox.Text+"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBycosto1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.examenesTableAdapter.FillBycosto1(this.mEDICODataSet.Examenes, ((decimal)(System.Convert.ChangeType(costoToolStripTextBox.Text, typeof(decimal)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBusqueda_Examen.SelectedRows.Count>0)
            {
                id_examen =Convert.ToInt32(dgvBusqueda_Examen.SelectedRows[0].Cells[0].Value); 
            }
            else
            {
                id_examen =Convert.ToInt32(dgvBusqueda_Examen.Rows[0].Cells[0].Value);
            }
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id_examen = 0;
            this.Close();
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.examenesTableAdapter.Fill(this.mEDICODataSet.Examenes);
            id_ExamenesToolStripTextBox.Text = "";
            nombre_ExamenToolStripTextBox.Text = "";
            costoToolStripTextBox.Text = "";
        }

        
    }
}
