using CLINICA.Clases;
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
    public partial class frmMedicos : Form
    {
        public bool nuevo = false;

        private int posicion;

        public frmMedicos()
        {
            InitializeComponent();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICODataSet);

        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.mEDICODataSet.Medicos);

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            id_MedicoTextBox.Text = "";
            HabilitarCampos();
            LimpiarCampos();
            nombresTextBox.Focus();
            
        }

        private void LimpiarCampos()
        {
            nombresTextBox.Text = "";
            dPITextBox.Text = "";
            apellidosTextBox.Text = "";
            direccionTextBox.Text = "";
            telefonoTextBox.Text = "";
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

            nombresTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            dPITextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            notasTextBox.Enabled = true;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ActualizarDatos();

        }

        private void ActualizarDatos()
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.mEDICODataSet.Medicos);
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

            nombresTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            dPITextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            notasTextBox.Enabled = false;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            HabilitarCampos();
            posicion = medicosBindingSource.Position;
            nombresTextBox.Focus();
    
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos()) return;
            if (nuevo)
            {
                Medicos.InsertMedico(dPITextBox.Text, nombresTextBox.Text, apellidosTextBox.Text, 
                                    direccionTextBox.Text, notasTextBox.Text, telefonoTextBox.Text);

            }
            else
            {
                Medicos.UpdateMedico(dPITextBox.Text, nombresTextBox.Text, apellidosTextBox.Text, 
                                    direccionTextBox.Text, nombresTextBox.Text, telefonoTextBox.Text, 
                                    Convert.ToInt32(id_MedicoTextBox.Text));
            }

            MessageBox.Show("Cambios realizados correctamente","Confirmacion");
            DesabilitarCampos();
            ActualizarDatos();
            if (!nuevo)
            {
                medicosBindingSource.Position = posicion;
            }

        }

        private bool validarCampos()
        {
            if (nombresTextBox.Text=="")
            {
                MessageBox.Show("Debe ingresar al menos un nombre", "Error");
                nombresTextBox.Focus();
                return false;
            }
            if (apellidosTextBox.Text=="")
            {
                MessageBox.Show("Debe ingresar al menor un apellido", "Error");
                apellidosTextBox.Focus();
                return false;
            }
            if (nuevo && Medicos.Existe_Medico(dPITextBox.Text))
            {
                MessageBox.Show("Ya existe un Medico con ese No.DPI", "Error");
                return false;
            }

            if (dPITextBox.Text=="")
            {
                MessageBox.Show("Debe ingresar un numero de DPI", "Error");
                dPITextBox.Focus();
                return false;
            }
            if (direccionTextBox.Text=="")
            {
                MessageBox.Show("Debe ingresar una direccion", "Error");
                direccionTextBox.Focus();
                return false;
            }
            if (telefonoTextBox.Text=="")
            {
                MessageBox.Show("Debe ingresar un numero de telefono", "Error");
                telefonoTextBox.Focus();
                return false;
            }

            return true;
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rpt = MessageBox.Show("Esta seguro de eliminar al medico de la tabla", "Confirmacion", MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rpt == DialogResult.No) return;

            Medicos.DeleteMedico(Convert.ToInt32(id_MedicoTextBox.Text));

            MessageBox.Show("Registro eliminado correctamente");
            ActualizarDatos();
            
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaMedico miMedido = new frmBusquedaMedico();

         
            miMedido.ShowDialog();

            if (miMedido.Id_medico == 0) return;

            medicosBindingSource.Position = medicosBindingSource.Find("id_Medico", miMedido.Id_medico);
        }

        
    }
}
