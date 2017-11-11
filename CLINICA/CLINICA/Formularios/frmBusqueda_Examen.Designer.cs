namespace CLINICA.Formularios
{
    partial class frmBusqueda_Examen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusqueda_Examen));
            this.dgvBusqueda_Examen = new System.Windows.Forms.DataGridView();
            this.idExamenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICODataSet = new CLINICA.MEDICODataSet();
            this.examenesTableAdapter = new CLINICA.MEDICODataSetTableAdapters.ExamenesTableAdapter();
            this.fillByid_ExamenesToolStrip = new System.Windows.Forms.ToolStrip();
            this.id_ExamenesToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.id_ExamenesToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByid_ExamenesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.fillBynombre_ExamenToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombre_ExamenToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombre_ExamenToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBynombre_ExamenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBycosto1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.costoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.costoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBycosto1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda_Examen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).BeginInit();
            this.fillByid_ExamenesToolStrip.SuspendLayout();
            this.fillBynombre_ExamenToolStrip.SuspendLayout();
            this.fillBycosto1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusqueda_Examen
            // 
            this.dgvBusqueda_Examen.AllowUserToAddRows = false;
            this.dgvBusqueda_Examen.AllowUserToDeleteRows = false;
            this.dgvBusqueda_Examen.AllowUserToOrderColumns = true;
            this.dgvBusqueda_Examen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda_Examen.AutoGenerateColumns = false;
            this.dgvBusqueda_Examen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda_Examen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idExamenesDataGridViewTextBoxColumn,
            this.nombreExamenDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dgvBusqueda_Examen.DataSource = this.examenesBindingSource;
            this.dgvBusqueda_Examen.Location = new System.Drawing.Point(12, 201);
            this.dgvBusqueda_Examen.Name = "dgvBusqueda_Examen";
            this.dgvBusqueda_Examen.ReadOnly = true;
            this.dgvBusqueda_Examen.Size = new System.Drawing.Size(562, 165);
            this.dgvBusqueda_Examen.TabIndex = 0;
            // 
            // idExamenesDataGridViewTextBoxColumn
            // 
            this.idExamenesDataGridViewTextBoxColumn.DataPropertyName = "id_Examenes";
            this.idExamenesDataGridViewTextBoxColumn.HeaderText = "ID Examenes";
            this.idExamenesDataGridViewTextBoxColumn.Name = "idExamenesDataGridViewTextBoxColumn";
            this.idExamenesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreExamenDataGridViewTextBoxColumn
            // 
            this.nombreExamenDataGridViewTextBoxColumn.DataPropertyName = "nombre_Examen";
            this.nombreExamenDataGridViewTextBoxColumn.HeaderText = "Nombre Examen";
            this.nombreExamenDataGridViewTextBoxColumn.Name = "nombreExamenDataGridViewTextBoxColumn";
            this.nombreExamenDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreExamenDataGridViewTextBoxColumn.Width = 150;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.costoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Width = 150;
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
            // examenesTableAdapter
            // 
            this.examenesTableAdapter.ClearBeforeFill = true;
            // 
            // fillByid_ExamenesToolStrip
            // 
            this.fillByid_ExamenesToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByid_ExamenesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.id_ExamenesToolStripLabel,
            this.id_ExamenesToolStripTextBox,
            this.fillByid_ExamenesToolStripButton});
            this.fillByid_ExamenesToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByid_ExamenesToolStrip.Name = "fillByid_ExamenesToolStrip";
            this.fillByid_ExamenesToolStrip.Size = new System.Drawing.Size(366, 25);
            this.fillByid_ExamenesToolStrip.TabIndex = 1;
            this.fillByid_ExamenesToolStrip.Text = "fillByid_ExamenesToolStrip";
            // 
            // id_ExamenesToolStripLabel
            // 
            this.id_ExamenesToolStripLabel.Name = "id_ExamenesToolStripLabel";
            this.id_ExamenesToolStripLabel.Size = new System.Drawing.Size(76, 22);
            this.id_ExamenesToolStripLabel.Text = "ID Examenes:";
            // 
            // id_ExamenesToolStripTextBox
            // 
            this.id_ExamenesToolStripTextBox.Margin = new System.Windows.Forms.Padding(25, 0, 1, 0);
            this.id_ExamenesToolStripTextBox.Name = "id_ExamenesToolStripTextBox";
            this.id_ExamenesToolStripTextBox.Size = new System.Drawing.Size(120, 25);
            // 
            // fillByid_ExamenesToolStripButton
            // 
            this.fillByid_ExamenesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByid_ExamenesToolStripButton.Name = "fillByid_ExamenesToolStripButton";
            this.fillByid_ExamenesToolStripButton.Size = new System.Drawing.Size(132, 22);
            this.fillByid_ExamenesToolStripButton.Text = "Filtrar por id_Examenes";
            this.fillByid_ExamenesToolStripButton.Click += new System.EventHandler(this.fillByid_ExamenesToolStripButton_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::CLINICA.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(286, 111);
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
            this.btnAceptar.Location = new System.Drawing.Point(161, 111);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 33);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // fillBynombre_ExamenToolStrip
            // 
            this.fillBynombre_ExamenToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBynombre_ExamenToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombre_ExamenToolStripLabel,
            this.nombre_ExamenToolStripTextBox,
            this.fillBynombre_ExamenToolStripButton});
            this.fillBynombre_ExamenToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBynombre_ExamenToolStrip.Name = "fillBynombre_ExamenToolStrip";
            this.fillBynombre_ExamenToolStrip.Size = new System.Drawing.Size(388, 25);
            this.fillBynombre_ExamenToolStrip.TabIndex = 8;
            this.fillBynombre_ExamenToolStrip.Text = "fillBynombre_ExamenToolStrip";
            // 
            // nombre_ExamenToolStripLabel
            // 
            this.nombre_ExamenToolStripLabel.Name = "nombre_ExamenToolStripLabel";
            this.nombre_ExamenToolStripLabel.Size = new System.Drawing.Size(98, 22);
            this.nombre_ExamenToolStripLabel.Text = "Nombre Examen:";
            // 
            // nombre_ExamenToolStripTextBox
            // 
            this.nombre_ExamenToolStripTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 1, 0);
            this.nombre_ExamenToolStripTextBox.Name = "nombre_ExamenToolStripTextBox";
            this.nombre_ExamenToolStripTextBox.Size = new System.Drawing.Size(120, 25);
            // 
            // fillBynombre_ExamenToolStripButton
            // 
            this.fillBynombre_ExamenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBynombre_ExamenToolStripButton.Name = "fillBynombre_ExamenToolStripButton";
            this.fillBynombre_ExamenToolStripButton.Size = new System.Drawing.Size(153, 22);
            this.fillBynombre_ExamenToolStripButton.Text = "Filtrar por nombre_Examen";
            this.fillBynombre_ExamenToolStripButton.Click += new System.EventHandler(this.fillBynombre_ExamenToolStripButton_Click);
            // 
            // fillBycosto1ToolStrip
            // 
            this.fillBycosto1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBycosto1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.costoToolStripLabel,
            this.costoToolStripTextBox,
            this.fillBycosto1ToolStripButton});
            this.fillBycosto1ToolStrip.Location = new System.Drawing.Point(0, 50);
            this.fillBycosto1ToolStrip.Name = "fillBycosto1ToolStrip";
            this.fillBycosto1ToolStrip.Size = new System.Drawing.Size(331, 25);
            this.fillBycosto1ToolStrip.TabIndex = 9;
            this.fillBycosto1ToolStrip.Text = "fillBycosto1ToolStrip";
            // 
            // costoToolStripLabel
            // 
            this.costoToolStripLabel.Name = "costoToolStripLabel";
            this.costoToolStripLabel.Size = new System.Drawing.Size(41, 22);
            this.costoToolStripLabel.Text = "Costo:";
            // 
            // costoToolStripTextBox
            // 
            this.costoToolStripTextBox.Margin = new System.Windows.Forms.Padding(63, 0, 1, 0);
            this.costoToolStripTextBox.Name = "costoToolStripTextBox";
            this.costoToolStripTextBox.Size = new System.Drawing.Size(120, 25);
            // 
            // fillBycosto1ToolStripButton
            // 
            this.fillBycosto1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBycosto1ToolStripButton.Name = "fillBycosto1ToolStripButton";
            this.fillBycosto1ToolStripButton.Size = new System.Drawing.Size(94, 22);
            this.fillBycosto1ToolStripButton.Text = "Filtrar por costo";
            this.fillBycosto1ToolStripButton.Click += new System.EventHandler(this.fillBycosto1ToolStripButton_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::CLINICA.Properties.Resources.eraser_1_;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(12, 111);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 33);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "&Limpiar Filtros";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLINICA.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(422, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmBusqueda_Examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.fillBycosto1ToolStrip);
            this.Controls.Add(this.fillBynombre_ExamenToolStrip);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.fillByid_ExamenesToolStrip);
            this.Controls.Add(this.dgvBusqueda_Examen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusqueda_Examen";
            this.Text = "frmBusqueda_Examen";
            this.Load += new System.EventHandler(this.frmBusqueda_Examen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda_Examen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICODataSet)).EndInit();
            this.fillByid_ExamenesToolStrip.ResumeLayout(false);
            this.fillByid_ExamenesToolStrip.PerformLayout();
            this.fillBynombre_ExamenToolStrip.ResumeLayout(false);
            this.fillBynombre_ExamenToolStrip.PerformLayout();
            this.fillBycosto1ToolStrip.ResumeLayout(false);
            this.fillBycosto1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda_Examen;
        private MEDICODataSet mEDICODataSet;
        private System.Windows.Forms.BindingSource examenesBindingSource;
        private MEDICODataSetTableAdapters.ExamenesTableAdapter examenesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExamenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExamenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByid_ExamenesToolStrip;
        private System.Windows.Forms.ToolStripLabel id_ExamenesToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox id_ExamenesToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByid_ExamenesToolStripButton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolStrip fillBynombre_ExamenToolStrip;
        private System.Windows.Forms.ToolStripLabel nombre_ExamenToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombre_ExamenToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBynombre_ExamenToolStripButton;
        private System.Windows.Forms.ToolStrip fillBycosto1ToolStrip;
        private System.Windows.Forms.ToolStripLabel costoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox costoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBycosto1ToolStripButton;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}