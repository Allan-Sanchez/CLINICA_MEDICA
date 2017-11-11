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
    public partial class frmExamenes : Form
    {
        public bool nuevo = false;
        private int posicion;

        public frmExamenes()
        {
            InitializeComponent();
        }

        private void examenesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examenesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICODataSet);

        }

        private void frmExamenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Examenes' Puede moverla o quitarla según sea necesario.
            this.examenesTableAdapter.Fill(this.mEDICODataSet.Examenes);
            EstablecerPermisos();

        }

        private void EstablecerPermisos()
        {
            //if (suarioLogiado !=1)
            //{
            //tsbGuardar.Enabled = false;
            //tsbEditar.Enabled = false;
            //tsbEliminar.Enabled = false;
            //tsbNuevo.Enabled = false;
                
            //}
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            id_ExamenesTextBox.Text = "";
            LimpiarCampos();
            HabilitarCampos();
            nombre_ExamenTextBox.Focus();
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

            nombre_ExamenTextBox.Enabled = true;
            costoTextBox.Enabled = true;
            notaTextBox.Enabled = true;

        }

        private void LimpiarCampos()
        {
            nombre_ExamenTextBox.Text = "";
            costoTextBox.Text = "";
            notaTextBox.Text = "";
           
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ActualizarFormulario();
        }

        private void ActualizarFormulario()
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Examenes' Puede moverla o quitarla según sea necesario.
            this.examenesTableAdapter.Fill(this.mEDICODataSet.Examenes);
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

            nombre_ExamenTextBox.Enabled = false;
            costoTextBox.Enabled = false;
            notaTextBox.Enabled = false;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            posicion=examenesBindingSource.Position;
            HabilitarCampos();
            nombre_ExamenTextBox.Focus();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar_Campos()) return;

            if (nuevo)
            {
                Examenes.Insert_Examen(nombre_ExamenTextBox.Text, Convert.ToDecimal(costoTextBox.Text), notaTextBox.Text);
            }
            else
            {
                Examenes.Update_Examen(nombre_ExamenTextBox.Text,Convert.ToDecimal(costoTextBox.Text),notaTextBox.Text,Convert.ToInt32(id_ExamenesTextBox.Text));
            }
            MessageBox.Show("Cambios realizados con exito", "Confirmacion");
            DesabilitarCampos();
            ActualizarFormulario();
            if (!nuevo)
            {
                examenesBindingSource.Position = posicion;
            }
        
            
        }

        private  bool Validar_Campos() 
        {
            if (nombre_ExamenTextBox.Text=="")
            {
                MessageBox.Show("Inserte un nombre de examen","Error");
                nombre_ExamenTextBox.Focus();
                return false;
            }

            //if (nuevo && Examenes.ExisteExamen(Convert.ToInt32(id_ExamenesTextBox.Text)))
            //{
            //    MessageBox.Show("El Examen ya existe", "Error");
            //    return false;
            //}

            if (nuevo && Examenes.Existe_Examen_igual(nombre_ExamenTextBox.Text))
            {
                MessageBox.Show("Un examen con ese nombre ya existe","Error");
                return false;
            }


             if (costoTextBox.Text=="")
            {
                MessageBox.Show("Inserte un Costo para el examen","Error");
                costoTextBox.Focus();
                return false;
            }

            if (!Utilidades.ValidarDecimal(costoTextBox.Text))
            {
                MessageBox.Show(Utilidades.Error,"Error");
                costoTextBox.Text="";
                costoTextBox.Focus();
                return false;
            }

            if (Utilidades.Numero_Decimal<0)
	        {
                MessageBox.Show("Debe ingresar un valor mayor a cero","Error");
                costoTextBox.Focus();
                return false;
		 
	        }

            return true;
	
	

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Esta seguro de borrar el registro actual?",
                "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            Examenes.Delete_Examen(Convert.ToInt32(id_ExamenesTextBox.Text));

            MessageBox.Show("Examen borrado correctamente","Confirmacion");
            ActualizarFormulario();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda_Examen miBusqueda = new frmBusqueda_Examen();

            miBusqueda.ShowDialog();

            if (miBusqueda.Id_examen == 0) return;
            examenesBindingSource.Position = examenesBindingSource.Find("id_Examenes", miBusqueda.Id_examen);

        }
    }
}
