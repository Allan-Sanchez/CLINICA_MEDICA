namespace CLINICA.Formularios
{
    partial class frmBusqueda_Paciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusqueda_Paciente));
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.idPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPIPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadeconsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoCasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICODataSet = new CLINICA.MEDICODataSet();
            this.pacientesTableAdapter = new CLINICA.MEDICODataSetTableAdapters.PacientesTableAdapter();
            this.fillByid_PacienteToolStrip = new System.Windows.Forms.ToolStrip();
            this.id_PacienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.id_PacienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByid_PacienteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBynombresToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombresToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBynombresToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByapellidosToolStrip = new System.Windows.Forms.ToolStrip();
            this.apellidosToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByapellidosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).BeginInit();
            this.fillByid_PacienteToolStrip.SuspendLayout();
            this.fillBynombresToolStrip.SuspendLayout();
            this.fillByapellidosToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToOrderColumns = true;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPacienteDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.dPIPacienteDataGridViewTextBoxColumn,
            this.fechadeconsultaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.telefonoCasaDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.dgvPacientes.DataSource = this.pacientesBindingSource;
            this.dgvPacientes.Location = new System.Drawing.Point(17, 174);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(740, 269);
            this.dgvPacientes.TabIndex = 0;
            // 
            // idPacienteDataGridViewTextBoxColumn
            // 
            this.idPacienteDataGridViewTextBoxColumn.DataPropertyName = "id_Paciente";
            this.idPacienteDataGridViewTextBoxColumn.HeaderText = "ID Paciente";
            this.idPacienteDataGridViewTextBoxColumn.Name = "idPacienteDataGridViewTextBoxColumn";
            this.idPacienteDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dPIPacienteDataGridViewTextBoxColumn
            // 
            this.dPIPacienteDataGridViewTextBoxColumn.DataPropertyName = "DPI_Paciente";
            this.dPIPacienteDataGridViewTextBoxColumn.HeaderText = "DPI_Paciente";
            this.dPIPacienteDataGridViewTextBoxColumn.Name = "dPIPacienteDataGridViewTextBoxColumn";
            this.dPIPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadeconsultaDataGridViewTextBoxColumn
            // 
            this.fechadeconsultaDataGridViewTextBoxColumn.DataPropertyName = "fecha_de_consulta";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.fechadeconsultaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechadeconsultaDataGridViewTextBoxColumn.HeaderText = "Fecha de consulta";
            this.fechadeconsultaDataGridViewTextBoxColumn.Name = "fechadeconsultaDataGridViewTextBoxColumn";
            this.fechadeconsultaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // telefonoCasaDataGridViewTextBoxColumn
            // 
            this.telefonoCasaDataGridViewTextBoxColumn.DataPropertyName = "telefono_Casa";
            this.telefonoCasaDataGridViewTextBoxColumn.HeaderText = "Teléfono Casa";
            this.telefonoCasaDataGridViewTextBoxColumn.Name = "telefonoCasaDataGridViewTextBoxColumn";
            this.telefonoCasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.mEDICODataSet;
            // 
            // mEDICODataSet
            // 
            this.mEDICODataSet.DataSetName = "MEDICODataSet";
            this.mEDICODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // fillByid_PacienteToolStrip
            // 
            this.fillByid_PacienteToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByid_PacienteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.id_PacienteToolStripLabel,
            this.id_PacienteToolStripTextBox,
            this.fillByid_PacienteToolStripButton});
            this.fillByid_PacienteToolStrip.Location = new System.Drawing.Point(0, 54);
            this.fillByid_PacienteToolStrip.Name = "fillByid_PacienteToolStrip";
            this.fillByid_PacienteToolStrip.Size = new System.Drawing.Size(310, 25);
            this.fillByid_PacienteToolStrip.TabIndex = 1;
            this.fillByid_PacienteToolStrip.Text = "fillByid_PacienteToolStrip";
            // 
            // id_PacienteToolStripLabel
            // 
            this.id_PacienteToolStripLabel.Name = "id_PacienteToolStripLabel";
            this.id_PacienteToolStripLabel.Size = new System.Drawing.Size(69, 22);
            this.id_PacienteToolStripLabel.Text = "ID Paciente:";
            // 
            // id_PacienteToolStripTextBox
            // 
            this.id_PacienteToolStripTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 1, 0);
            this.id_PacienteToolStripTextBox.Name = "id_PacienteToolStripTextBox";
            this.id_PacienteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByid_PacienteToolStripButton
            // 
            this.fillByid_PacienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByid_PacienteToolStripButton.Name = "fillByid_PacienteToolStripButton";
            this.fillByid_PacienteToolStripButton.Size = new System.Drawing.Size(124, 22);
            this.fillByid_PacienteToolStripButton.Text = "Filtrar por &ID Paciente";
            this.fillByid_PacienteToolStripButton.Click += new System.EventHandler(this.fillByid_PacienteToolStripButton_Click);
            // 
            // fillBynombresToolStrip
            // 
            this.fillBynombresToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBynombresToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombresToolStripLabel,
            this.nombresToolStripTextBox,
            this.fillBynombresToolStripButton});
            this.fillBynombresToolStrip.Location = new System.Drawing.Point(0, 4);
            this.fillBynombresToolStrip.Name = "fillBynombresToolStrip";
            this.fillBynombresToolStrip.Size = new System.Drawing.Size(300, 25);
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
            this.nombresToolStripTextBox.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.nombresToolStripTextBox.Name = "nombresToolStripTextBox";
            this.nombresToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBynombresToolStripButton
            // 
            this.fillBynombresToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBynombresToolStripButton.Name = "fillBynombresToolStripButton";
            this.fillBynombresToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillBynombresToolStripButton.Text = "Filtrar por &Nombres";
            this.fillBynombresToolStripButton.Click += new System.EventHandler(this.fillBynombresToolStripButton_Click);
            // 
            // fillByapellidosToolStrip
            // 
            this.fillByapellidosToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByapellidosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apellidosToolStripLabel,
            this.apellidosToolStripTextBox,
            this.fillByapellidosToolStripButton});
            this.fillByapellidosToolStrip.Location = new System.Drawing.Point(1, 29);
            this.fillByapellidosToolStrip.Name = "fillByapellidosToolStrip";
            this.fillByapellidosToolStrip.Size = new System.Drawing.Size(300, 25);
            this.fillByapellidosToolStrip.TabIndex = 3;
            this.fillByapellidosToolStrip.Text = "fillByapellidosToolStrip";
            // 
            // apellidosToolStripLabel
            // 
            this.apellidosToolStripLabel.Name = "apellidosToolStripLabel";
            this.apellidosToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.apellidosToolStripLabel.Text = "Apellidos:";
            // 
            // apellidosToolStripTextBox
            // 
            this.apellidosToolStripTextBox.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.apellidosToolStripTextBox.Name = "apellidosToolStripTextBox";
            this.apellidosToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByapellidosToolStripButton
            // 
            this.fillByapellidosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByapellidosToolStripButton.Name = "fillByapellidosToolStripButton";
            this.fillByapellidosToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillByapellidosToolStripButton.Text = "Filtrar por A&pellidos";
            this.fillByapellidosToolStripButton.Click += new System.EventHandler(this.fillByapellidosToolStripButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLINICA.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(490, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::CLINICA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(299, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 33);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::CLINICA.Properties.Resources.checkmark;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(187, 107);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 33);
            this.btnAceptar.TabIndex = 13;
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
            this.btnLimpiar.Location = new System.Drawing.Point(41, 107);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 33);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "&Limpiar Filtros";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmBusqueda_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 455);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fillByapellidosToolStrip);
            this.Controls.Add(this.fillBynombresToolStrip);
            this.Controls.Add(this.fillByid_PacienteToolStrip);
            this.Controls.Add(this.dgvPacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusqueda_Paciente";
            this.Text = "Busqueda de Pacientes";
            this.Load += new System.EventHandler(this.frmBusqueda_Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).EndInit();
            this.fillByid_PacienteToolStrip.ResumeLayout(false);
            this.fillByid_PacienteToolStrip.PerformLayout();
            this.fillBynombresToolStrip.ResumeLayout(false);
            this.fillBynombresToolStrip.PerformLayout();
            this.fillByapellidosToolStrip.ResumeLayout(false);
            this.fillByapellidosToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacientes;
        private MEDICODataSet mEDICODataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private MEDICODataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPIPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadeconsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByid_PacienteToolStrip;
        private System.Windows.Forms.ToolStripLabel id_PacienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox id_PacienteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByid_PacienteToolStripButton;
        private System.Windows.Forms.ToolStrip fillBynombresToolStrip;
        private System.Windows.Forms.ToolStripLabel nombresToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBynombresToolStripButton;
        private System.Windows.Forms.ToolStrip fillByapellidosToolStrip;
        private System.Windows.Forms.ToolStripLabel apellidosToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByapellidosToolStripButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}