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
    public partial class frmPacientes : Form
    {
        public bool nuevo = false;
        private int posicion;
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICODataSet);

        }

        private void pacientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICODataSet);

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.mEDICODataSet.Pacientes);

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            id_PacienteTextBox.Text = "";
            HabilitarCampos();
            LimpiarCampos();
            nombresTextBox.Focus();
        }

        private void LimpiarCampos()
        {
            nombresTextBox.Text = "";
            apellidosTextBox.Text = "";
            dPI_PacienteTextBox.Text = "";
            direccionTextBox.Text = "";
            telefonoTextBox.Text = "";
            telefono_CasaTextBox.Text = "";
            notasTextBox.Text = "";
            
        }

        private void HabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;

            tsbNuevo.Enabled = false;
            tsbEditar.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbGuardar.Enabled = true;
            tsbBuscar.Enabled = false;
            tsbEliminar.Enabled = false;

            dPI_PacienteTextBox.Enabled = true;
            nombresTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            fecha_de_consultaDateTimePicker.Enabled = true;
            direccionTextBox.Enabled = true;
            telefono_CasaTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            notasTextBox.Enabled = true;

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            HabilitarCampos();
            posicion = pacientesBindingSource.Position;
            nombresTextBox.Focus();
            
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.mEDICODataSet.Pacientes);
        }

        private void DesabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;

            tsbNuevo.Enabled = true;
            tsbEditar.Enabled = true;
            tsbCancelar.Enabled = false;
            tsbGuardar.Enabled = false;
            tsbBuscar.Enabled = true;
            tsbEliminar.Enabled = true;

            dPI_PacienteTextBox.Enabled = false;
            nombresTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            fecha_de_consultaDateTimePicker.Enabled = false;
            direccionTextBox.Enabled = false;
            telefono_CasaTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            notasTextBox.Enabled = false;
           
        }
    }
}
