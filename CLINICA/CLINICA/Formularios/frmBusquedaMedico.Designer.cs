namespace CLINICA.Formularios
{
    partial class frmBusquedaMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaMedico));
            this.dgvBusquedaMedico = new System.Windows.Forms.DataGridView();
            this.idMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICODataSet = new CLINICA.MEDICODataSet();
            this.fillByid_Medico1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.id_MedicoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.id_MedicoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByid_Medico1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBynombresToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombresToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBynombresToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.medicosTableAdapter = new CLINICA.MEDICODataSetTableAdapters.MedicosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).BeginInit();
            this.fillByid_Medico1ToolStrip.SuspendLayout();
            this.fillBynombresToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusquedaMedico
            // 
            this.dgvBusquedaMedico.AllowUserToAddRows = false;
            this.dgvBusquedaMedico.AllowUserToDeleteRows = false;
            this.dgvBusquedaMedico.AllowUserToOrderColumns = true;
            this.dgvBusquedaMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusquedaMedico.AutoGenerateColumns = false;
            this.dgvBusquedaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicoDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.dPIDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.dgvBusquedaMedico.DataSource = this.medicosBindingSource;
            this.dgvBusquedaMedico.Location = new System.Drawing.Point(4, 169);
            this.dgvBusquedaMedico.Name = "dgvBusquedaMedico";
            this.dgvBusquedaMedico.ReadOnly = true;
            this.dgvBusquedaMedico.Size = new System.Drawing.Size(603, 167);
            this.dgvBusquedaMedico.TabIndex = 0;
            // 
            // idMedicoDataGridViewTextBoxColumn
            // 
            this.idMedicoDataGridViewTextBoxColumn.DataPropertyName = "id_Medico";
            this.idMedicoDataGridViewTextBoxColumn.HeaderText = "ID Medico";
            this.idMedicoDataGridViewTextBoxColumn.Name = "idMedicoDataGridViewTextBoxColumn";
            this.idMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dPIDataGridViewTextBoxColumn
            // 
            this.dPIDataGridViewTextBoxColumn.DataPropertyName = "DPI";
            this.dPIDataGridViewTextBoxColumn.HeaderText = "DPI";
            this.dPIDataGridViewTextBoxColumn.Name = "dPIDataGridViewTextBoxColumn";
            this.dPIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.mEDICODataSet;
            // 
            // mEDICODataSet
            // 
            this.mEDICODataSet.DataSetName = "MEDICODataSet";
            this.mEDICODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByid_Medico1ToolStrip
            // 
            this.fillByid_Medico1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByid_Medico1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.id_MedicoToolStripLabel,
            this.id_MedicoToolStripTextBox,
            this.fillByid_Medico1ToolStripButton});
            this.fillByid_Medico1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByid_Medico1ToolStrip.Name = "fillByid_Medico1ToolStrip";
            this.fillByid_Medico1ToolStrip.Size = new System.Drawing.Size(297, 25);
            this.fillByid_Medico1ToolStrip.TabIndex = 1;
            this.fillByid_Medico1ToolStrip.Text = "fillByid_Medico1ToolStrip";
            // 
            // id_MedicoToolStripLabel
            // 
            this.id_MedicoToolStripLabel.Name = "id_MedicoToolStripLabel";
            this.id_MedicoToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.id_MedicoToolStripLabel.Text = "ID Medico:";
            // 
            // id_MedicoToolStripTextBox
            // 
            this.id_MedicoToolStripTextBox.Name = "id_MedicoToolStripTextBox";
            this.id_MedicoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByid_Medico1ToolStripButton
            // 
            this.fillByid_Medico1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByid_Medico1ToolStripButton.Name = "fillByid_Medico1ToolStripButton";
            this.fillByid_Medico1ToolStripButton.Size = new System.Drawing.Size(119, 22);
            this.fillByid_Medico1ToolStripButton.Text = "Filtrar por ID Medico";
            this.fillByid_Medico1ToolStripButton.Click += new System.EventHandler(this.fillByid_Medico1ToolStripButton_Click);
            // 
            // fillBynombresToolStrip
            // 
            this.fillBynombresToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBynombresToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombresToolStripLabel,
            this.nombresToolStripTextBox,
            this.fillBynombresToolStripButton});
            this.fillBynombresToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillBynombresToolStrip.Name = "fillBynombresToolStrip";
            this.fillBynombresToolStrip.Size = new System.Drawing.Size(293, 25);
            this.fillBynombresToolStrip.TabIndex = 2;
            this.fillBynombresToolStrip.Text = "fillBynombresToolStrip";
            // 
            // nombresToolStripLabel
            // 
            this.nombresToolStripLabel.Name = "nombresToolStripLabel";
            this.nombresToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.nombresToolStripLabel.Text = "Nombres:";
            // 
            // nombresToolStripTextBox
            // 
            this.nombresToolStripTextBox.Margin = new System.Windows.Forms.Padding(7, 0, 1, 0);
            this.nombresToolStripTextBox.Name = "nombresToolStripTextBox";
            this.nombresToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBynombresToolStripButton
            // 
            this.fillBynombresToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBynombresToolStripButton.Name = "fillBynombresToolStripButton";
            this.fillBynombresToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillBynombresToolStripButton.Text = "Filtrar por Nombres";
            this.fillBynombresToolStripButton.Click += new System.EventHandler(this.fillBynombresToolStripButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLINICA.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(394, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::CLINICA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(258, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::CLINICA.Properties.Resources.checkmark;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(146, 69);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 33);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::CLINICA.Properties.Resources.eraser_1_;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 69);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 33);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "&Limpiar Filtros";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // frmBusquedaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.fillBynombresToolStrip);
            this.Controls.Add(this.fillByid_Medico1ToolStrip);
            this.Controls.Add(this.dgvBusquedaMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaMedico";
            this.Text = "Busqueda Medico";
            this.Load += new System.EventHandler(this.frmBusquedaMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).EndInit();
            this.fillByid_Medico1ToolStrip.ResumeLayout(false);
            this.fillByid_Medico1ToolStrip.PerformLayout();
            this.fillBynombresToolStrip.ResumeLayout(false);
            this.fillBynombresToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusquedaMedico;
        private MEDICODataSet mEDICODataSet;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private MEDICODataSetTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.ToolStrip fillByid_Medico1ToolStrip;
        private System.Windows.Forms.ToolStripLabel id_MedicoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox id_MedicoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByid_Medico1ToolStripButton;
        private System.Windows.Forms.ToolStrip fillBynombresToolStrip;
        private System.Windows.Forms.ToolStripLabel nombresToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBynombresToolStripButton;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}