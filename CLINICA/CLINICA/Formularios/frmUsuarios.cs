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
    public partial class frmUsuarios : Form
    {
        public bool nuevo = false;
        private int posicion;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICODataSet);

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICODataSet);

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.mEDICODataSet.Usuarios);

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            HabilitarCampos();
            LimpiarCampos();
            nombresTextBox.Focus();
        }

        private void LimpiarCampos()
        {
            nombresTextBox.Text = "";
            apellidosTextBox.Text = "";
            id_PerfilTextBox.Text = "";
            usuarioTextBox.Text = "";
            claveTextBox.Text = "";
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
            tsbEliminar.Enabled = false;

            nombresTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            id_PerfilTextBox.Enabled = true;
            usuarioTextBox.Enabled = true;
            claveTextBox.Enabled = true;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ActualizarDatos();
            
        }

        private void ActualizarDatos()
        {
            // TODO: esta línea de código carga datos en la tabla 'mEDICODataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.mEDICODataSet.Usuarios);
        }

        private void DesabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;

            tsbNuevo.Enabled = true;
            tsbEditar.Enabled = true;
            tsbCancelar.Enabled = false ;
            tsbGuardar.Enabled = false;
            tsbEliminar.Enabled = true;

            nombresTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            id_PerfilTextBox.Enabled = false;
            usuarioTextBox.Enabled = false;
            claveTextBox.Enabled = false;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            HabilitarCampos();
            nombresTextBox.Focus();
            posicion = usuariosBindingSource.Position;
           
            
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rpt = MessageBox.Show("Esta seguro de eliminar al usuario de la tabla", "Confirmacion", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rpt == DialogResult.No) return;

            NewUsuario.DeleteUsuario(usuarioTextBox.Text);
            MessageBox.Show("Datos eliminado correctamente", "Confirmacion");
            ActualizarDatos();
 
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampor()) return;
            if (nuevo)
            {
                NewUsuario.InsertUsuario(usuarioTextBox.Text, claveTextBox.Text, 
                            nombresTextBox.Text, apellidosTextBox.Text, Convert.ToInt32(id_PerfilTextBox.Text));
            }
            else
            {
                NewUsuario.UpdateUsuario(usuarioTextBox.Text, claveTextBox.Text, nombresTextBox.Text, 
                    apellidosTextBox.Text, Convert.ToInt32(id_PerfilTextBox.Text));
            }
            MessageBox.Show("Cambios realizados exitosamente", "Confirmacion");
            ActualizarDatos();
            DesabilitarCampos();
            if (!nuevo)
            {
                usuariosBindingSource.Position = posicion;
            }
        }

        private bool ValidarCampor()
        {
            if (nombresTextBox.Text=="")
            {
                MessageBox.Show("Debes ingresar al menos un nombre", "Error");
                nombresTextBox.Focus();
                return false;
            }
            if (apellidosTextBox.Text=="")
            {
                MessageBox.Show("Debes ingresar al menos un apellido", "Error");
                apellidosTextBox.Focus();
                return false;   
            }
            if (usuarioTextBox.Text=="")
            {
                MessageBox.Show("Debes ingresar un nombre de usuario", "Error");
                usuarioTextBox.Focus();
                return false;
            }
            if (claveTextBox.Text=="")
            {
                MessageBox.Show("Debe ingresar una clave de usuario", "Error");
                claveTextBox.Focus();
                return false;
            }
            if (id_PerfilTextBox.Text=="")
            {
                MessageBox.Show("Deb ingresar permisos validos { 1 , 2 }", "Error");
                id_PerfilTextBox.Focus();
                return false;
            }
            if (Convert.ToInt32(id_PerfilTextBox.Text)>2||Convert.ToInt32(id_PerfilTextBox.Text)<=0)
            {
                MessageBox.Show("Debe elegir entre {1} o {2}", "Error");
                id_PerfilTextBox.Text = "";
                id_PerfilTextBox.Focus();
                return false;
            }
            if (nuevo && NewUsuario.Existe_Usuario(usuarioTextBox.Text))
            {
                MessageBox.Show("El usuario ya existe.", "Error");
                usuarioTextBox.Text = "";
                usuarioTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
