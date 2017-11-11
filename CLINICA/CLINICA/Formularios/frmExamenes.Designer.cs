namespace CLINICA.Formularios
{
    partial class frmExamenes
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
            System.Windows.Forms.Label nombre_ExamenLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label notaLabel;
            System.Windows.Forms.Label id_ExamenesLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamenes));
            this.examenesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.examenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICODataSet = new CLINICA.MEDICODataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.examenesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_ExamenTextBox = new System.Windows.Forms.TextBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.notaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_ExamenesTextBox = new System.Windows.Forms.TextBox();
            this.examenesTableAdapter = new CLINICA.MEDICODataSetTableAdapters.ExamenesTableAdapter();
            this.tableAdapterManager = new CLINICA.MEDICODataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            nombre_ExamenLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            id_ExamenesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingNavigator)).BeginInit();
            this.examenesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_ExamenLabel
            // 
            nombre_ExamenLabel.AutoSize = true;
            nombre_ExamenLabel.Location = new System.Drawing.Point(9, 69);
            nombre_ExamenLabel.Name = "nombre_ExamenLabel";
            nombre_ExamenLabel.Size = new System.Drawing.Size(92, 13);
            nombre_ExamenLabel.TabIndex = 2;
            nombre_ExamenLabel.Text = "&Nombre Examen*:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Location = new System.Drawing.Point(59, 95);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(41, 13);
            costoLabel.TabIndex = 4;
            costoLabel.Text = "&Costo*:";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new System.Drawing.Point(64, 133);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(33, 13);
            notaLabel.TabIndex = 6;
            notaLabel.Text = "N&ota:";
            // 
            // id_ExamenesLabel
            // 
            id_ExamenesLabel.AutoSize = true;
            id_ExamenesLabel.Location = new System.Drawing.Point(25, 43);
            id_ExamenesLabel.Name = "id_ExamenesLabel";
            id_ExamenesLabel.Size = new System.Drawing.Size(73, 13);
            id_ExamenesLabel.TabIndex = 10;
            id_ExamenesLabel.Text = "ID Examenes:";
            // 
            // examenesBindingNavigator
            // 
            this.examenesBindingNavigator.AddNewItem = null;
            this.examenesBindingNavigator.BindingSource = this.examenesBindingSource;
            this.examenesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.examenesBindingNavigator.DeleteItem = null;
            this.examenesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.examenesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.examenesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.examenesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.examenesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.examenesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.examenesBindingNavigator.Name = "examenesBindingNavigator";
            this.examenesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.examenesBindingNavigator.Size = new System.Drawing.Size(626, 25);
            this.examenesBindingNavigator.TabIndex = 0;
            this.examenesBindingNavigator.Text = "bindingNavigator1";
            // 
            // examenesBindingSource
            // 
            this.examenesBindingSource.DataMember = "Examenes";
            this.examenesBindingSource.DataSource = this.mEDICODataSet;
            // 
            // mEDICODataSet
            // 
            this.mEDICODataSet.DataSetName = "MEDICODataSet";
            this.mEDICODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // examenesDataGridView
            // 
            this.examenesDataGridView.AllowUserToAddRows = false;
            this.examenesDataGridView.AllowUserToDeleteRows = false;
            this.examenesDataGridView.AllowUserToOrderColumns = true;
            this.examenesDataGridView.AutoGenerateColumns = false;
            this.examenesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examenesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.examenesDataGridView.DataSource = this.examenesBindingSource;
            this.examenesDataGridView.Location = new System.Drawing.Point(12, 240);
            this.examenesDataGridView.Name = "examenesDataGridView";
            this.examenesDataGridView.ReadOnly = true;
            this.examenesDataGridView.Size = new System.Drawing.Size(584, 151);
            this.examenesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Examenes";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Examenes";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_Examen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Examen";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "costo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nota";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nota";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // nombre_ExamenTextBox
            // 
            this.nombre_ExamenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examenesBindingSource, "nombre_Examen", true));
            this.nombre_ExamenTextBox.Enabled = false;
            this.nombre_ExamenTextBox.Location = new System.Drawing.Point(101, 66);
            this.nombre_ExamenTextBox.Name = "nombre_ExamenTextBox";
            this.nombre_ExamenTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_ExamenTextBox.TabIndex = 3;
            // 
            // costoTextBox
            // 
            this.costoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examenesBindingSource, "costo", true));
            this.costoTextBox.Enabled = false;
            this.costoTextBox.Location = new System.Drawing.Point(101, 98);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(100, 20);
            this.costoTextBox.TabIndex = 5;
            // 
            // notaTextBox
            // 
            this.notaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examenesBindingSource, "nota", true));
            this.notaTextBox.Enabled = false;
            this.notaTextBox.Location = new System.Drawing.Point(101, 130);
            this.notaTextBox.Multiline = true;
            this.notaTextBox.Name = "notaTextBox";
            this.notaTextBox.Size = new System.Drawing.Size(200, 71);
            this.notaTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "* Campos obligatorios";
            // 
            // id_ExamenesTextBox
            // 
            this.id_ExamenesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.examenesBindingSource, "id_Examenes", true));
            this.id_ExamenesTextBox.Enabled = false;
            this.id_ExamenesTextBox.Location = new System.Drawing.Point(101, 40);
            this.id_ExamenesTextBox.Name = "id_ExamenesTextBox";
            this.id_ExamenesTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ExamenesTextBox.TabIndex = 11;
            // 
            // examenesTableAdapter
            // 
            this.examenesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultaTableAdapter = null;
            this.tableAdapterManager.ExamenesTableAdapter = this.examenesTableAdapter;
            this.tableAdapterManager.MedicosTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CLINICA.MEDICODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLINICA.Properties.Resources.if_medical_icon_1_1290990;
            this.pictureBox1.Location = new System.Drawing.Point(401, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            // frmExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(626, 433);
            this.Controls.Add(id_ExamenesLabel);
            this.Controls.Add(this.id_ExamenesTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(notaLabel);
            this.Controls.Add(this.notaTextBox);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(nombre_ExamenLabel);
            this.Controls.Add(this.nombre_ExamenTextBox);
            this.Controls.Add(this.examenesDataGridView);
            this.Controls.Add(this.examenesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExamenes";
            this.Text = "Lista de Examenes";
            this.Load += new System.EventHandler(this.frmExamenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingNavigator)).EndInit();
            this.examenesBindingNavigator.ResumeLayout(false);
            this.examenesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MEDICODataSet mEDICODataSet;
        private System.Windows.Forms.BindingSource examenesBindingSource;
        private MEDICODataSetTableAdapters.ExamenesTableAdapter examenesTableAdapter;
        private MEDICODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator examenesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView examenesDataGridView;
        private System.Windows.Forms.TextBox nombre_ExamenTextBox;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.TextBox notaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.TextBox id_ExamenesTextBox;
    }
}