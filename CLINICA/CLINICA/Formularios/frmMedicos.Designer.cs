namespace CLINICA.Formularios
{
    partial class frmMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dPILabel;
            System.Windows.Forms.Label id_MedicoLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label notasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicos));
            this.mEDICODataSet = new CLINICA.MEDICODataSet();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new CLINICA.MEDICODataSetTableAdapters.MedicosTableAdapter();
            this.tableAdapterManager = new CLINICA.MEDICODataSetTableAdapters.TableAdapterManager();
            this.medicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.medicosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPITextBox = new System.Windows.Forms.TextBox();
            this.id_MedicoTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.lblCampo_Obligatorios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            dPILabel = new System.Windows.Forms.Label();
            id_MedicoLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).BeginInit();
            this.medicosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dPILabel
            // 
            dPILabel.AutoSize = true;
            dPILabel.Location = new System.Drawing.Point(345, 43);
            dPILabel.Name = "dPILabel";
            dPILabel.Size = new System.Drawing.Size(32, 13);
            dPILabel.TabIndex = 2;
            dPILabel.Text = "&DPI*:";
            // 
            // id_MedicoLabel
            // 
            id_MedicoLabel.AutoSize = true;
            id_MedicoLabel.Location = new System.Drawing.Point(6, 47);
            id_MedicoLabel.Name = "id_MedicoLabel";
            id_MedicoLabel.Size = new System.Drawing.Size(59, 13);
            id_MedicoLabel.TabIndex = 4;
            id_MedicoLabel.Text = "&ID Medico:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(12, 86);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(56, 13);
            nombresLabel.TabIndex = 6;
            nombresLabel.Text = "&Nombres*:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(11, 122);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(56, 13);
            apellidosLabel.TabIndex = 8;
            apellidosLabel.Text = "&Apellidos*:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(340, 86);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(59, 13);
            direccionLabel.TabIndex = 10;
            direccionLabel.Text = "D&irección*:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(345, 125);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(56, 13);
            telefonoLabel.TabIndex = 12;
            telefonoLabel.Text = "&Teléfono*:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(26, 162);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 14;
            notasLabel.Text = "N&otas:";
            // 
            // mEDICODataSet
            // 
            this.mEDICODataSet.DataSetName = "MEDICODataSet";
            this.mEDICODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.mEDICODataSet;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.ExamenesTableAdapter = null;
            this.tableAdapterManager.MedicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CLINICA.MEDICODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // medicosBindingNavigator
            // 
            this.medicosBindingNavigator.AddNewItem = null;
            this.medicosBindingNavigator.BindingSource = this.medicosBindingSource;
            this.medicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicosBindingNavigator.DeleteItem = null;
            this.medicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbCancelar,
            this.tsbGuardar,
            this.tsbBuscar,
            this.tsbEliminar});
            this.medicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicosBindingNavigator.Name = "medicosBindingNavigator";
            this.medicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicosBindingNavigator.Size = new System.Drawing.Size(842, 25);
            this.medicosBindingNavigator.TabIndex = 0;
            this.medicosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::CLINICA.Properties.Resources.plus;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ToolTipText = "Boton para habilitar los campos";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::CLINICA.Properties.Resources.edit;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.ToolTipText = "Boton para editar un examen existente";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = global::CLINICA.Properties.Resources.cancel1;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.ToolTipText = "Boton para cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Enabled = false;
            this.tsbGuardar.Image = global::CLINICA.Properties.Resources.save;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.ToolTipText = "Boton para guardar un nuevo tipo de examen";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = global::CLINICA.Properties.Resources.search;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.ToolTipText = "Botono para Buscar un examen";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::CLINICA.Properties.Resources.delete;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.ToolTipText = "Boton para eliminar un examen de la lista";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // medicosDataGridView
            // 
            this.medicosDataGridView.AllowUserToAddRows = false;
            this.medicosDataGridView.AllowUserToDeleteRows = false;
            this.medicosDataGridView.AllowUserToOrderColumns = true;
            this.medicosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicosDataGridView.AutoGenerateColumns = false;
            this.medicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            this.medicosDataGridView.DataSource = this.medicosBindingSource;
            this.medicosDataGridView.Location = new System.Drawing.Point(9, 254);
            this.medicosDataGridView.Name = "medicosDataGridView";
            this.medicosDataGridView.ReadOnly = true;
            this.medicosDataGridView.Size = new System.Drawing.Size(792, 196);
            this.medicosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Medico";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Medico";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombres";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DPI";
            this.dataGridViewTextBoxColumn2.HeaderText = "DPI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "notas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dPITextBox
            // 
            this.dPITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "DPI", true));
            this.dPITextBox.Enabled = false;
            this.dPITextBox.Location = new System.Drawing.Point(405, 40);
            this.dPITextBox.Name = "dPITextBox";
            this.dPITextBox.Size = new System.Drawing.Size(182, 20);
            this.dPITextBox.TabIndex = 3;
            // 
            // id_MedicoTextBox
            // 
            this.id_MedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "id_Medico", true));
            this.id_MedicoTextBox.Enabled = false;
            this.id_MedicoTextBox.Location = new System.Drawing.Point(68, 44);
            this.id_MedicoTextBox.Name = "id_MedicoTextBox";
            this.id_MedicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_MedicoTextBox.TabIndex = 5;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "nombres", true));
            this.nombresTextBox.Enabled = false;
            this.nombresTextBox.Location = new System.Drawing.Point(68, 83);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(224, 20);
            this.nombresTextBox.TabIndex = 7;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "apellidos", true));
            this.apellidosTextBox.Enabled = false;
            this.apellidosTextBox.Location = new System.Drawing.Point(68, 119);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(224, 20);
            this.apellidosTextBox.TabIndex = 9;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "direccion", true));
            this.direccionTextBox.Enabled = false;
            this.direccionTextBox.Location = new System.Drawing.Point(405, 83);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(182, 20);
            this.direccionTextBox.TabIndex = 11;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "telefono", true));
            this.telefonoTextBox.Enabled = false;
            this.telefonoTextBox.Location = new System.Drawing.Point(405, 122);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 13;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "notas", true));
            this.notasTextBox.Enabled = false;
            this.notasTextBox.Location = new System.Drawing.Point(68, 159);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(224, 75);
            this.notasTextBox.TabIndex = 15;
            // 
            // lblCampo_Obligatorios
            // 
            this.lblCampo_Obligatorios.AutoSize = true;
            this.lblCampo_Obligatorios.Location = new System.Drawing.Point(345, 173);
            this.lblCampo_Obligatorios.Name = "lblCampo_Obligatorios";
            this.lblCampo_Obligatorios.Size = new System.Drawing.Size(110, 13);
            this.lblCampo_Obligatorios.TabIndex = 16;
            this.lblCampo_Obligatorios.Text = "* Campos Obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLINICA.Properties.Resources.doctor;
            this.pictureBox1.Location = new System.Drawing.Point(638, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCampo_Obligatorios);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(id_MedicoLabel);
            this.Controls.Add(this.id_MedicoTextBox);
            this.Controls.Add(dPILabel);
            this.Controls.Add(this.dPITextBox);
            this.Controls.Add(this.medicosDataGridView);
            this.Controls.Add(this.medicosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicos";
            this.Text = "Lista Medicos";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).EndInit();
            this.medicosBindingNavigator.ResumeLayout(false);
            this.medicosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MEDICODataSet mEDICODataSet;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private MEDICODataSetTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private MEDICODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView medicosDataGridView;
        private System.Windows.Forms.TextBox dPITextBox;
        private System.Windows.Forms.TextBox id_MedicoTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.Label lblCampo_Obligatorios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}