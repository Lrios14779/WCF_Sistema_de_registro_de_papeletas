namespace Test_Final
{
    partial class WindowsFechas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecini = new System.Windows.Forms.DateTimePicker();
            this.dtpFecfin = new System.Windows.Forms.DateTimePicker();
            this.dtgListadoFechas = new System.Windows.Forms.DataGridView();
            this.btnFechas = new System.Windows.Forms.Button();
            this.infraccionesFechas = new Test_Final.InfraccionesFechas();
            this.tbPapeletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PapeletaTableAdapter = new Test_Final.InfraccionesFechasTableAdapters.Tb_PapeletaTableAdapter();
            this.numPapeletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecPapeletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codInfraccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estPapeletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infraccionesFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPapeletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de fin:";
            // 
            // dtpFecini
            // 
            this.dtpFecini.Location = new System.Drawing.Point(94, 96);
            this.dtpFecini.Name = "dtpFecini";
            this.dtpFecini.Size = new System.Drawing.Size(200, 20);
            this.dtpFecini.TabIndex = 3;
            // 
            // dtpFecfin
            // 
            this.dtpFecfin.Location = new System.Drawing.Point(345, 96);
            this.dtpFecfin.Name = "dtpFecfin";
            this.dtpFecfin.Size = new System.Drawing.Size(200, 20);
            this.dtpFecfin.TabIndex = 4;
            // 
            // dtgListadoFechas
            // 
            this.dtgListadoFechas.AutoGenerateColumns = false;
            this.dtgListadoFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListadoFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPapeletaDataGridViewTextBoxColumn,
            this.fecPapeletaDataGridViewTextBoxColumn,
            this.codInfraccionDataGridViewTextBoxColumn,
            this.numPlacaDataGridViewTextBoxColumn,
            this.estPapeletaDataGridViewTextBoxColumn});
            this.dtgListadoFechas.DataSource = this.tbPapeletaBindingSource;
            this.dtgListadoFechas.Location = new System.Drawing.Point(94, 157);
            this.dtgListadoFechas.Name = "dtgListadoFechas";
            this.dtgListadoFechas.Size = new System.Drawing.Size(540, 217);
            this.dtgListadoFechas.TabIndex = 5;
            // 
            // btnFechas
            // 
            this.btnFechas.Location = new System.Drawing.Point(559, 97);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(75, 23);
            this.btnFechas.TabIndex = 6;
            this.btnFechas.Text = "Mostrar";
            this.btnFechas.UseVisualStyleBackColor = true;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // infraccionesFechas
            // 
            this.infraccionesFechas.DataSetName = "InfraccionesFechas";
            this.infraccionesFechas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPapeletaBindingSource
            // 
            this.tbPapeletaBindingSource.DataMember = "Tb_Papeleta";
            this.tbPapeletaBindingSource.DataSource = this.infraccionesFechas;
            // 
            // tb_PapeletaTableAdapter
            // 
            this.tb_PapeletaTableAdapter.ClearBeforeFill = true;
            // 
            // numPapeletaDataGridViewTextBoxColumn
            // 
            this.numPapeletaDataGridViewTextBoxColumn.DataPropertyName = "Num_Papeleta";
            this.numPapeletaDataGridViewTextBoxColumn.HeaderText = "Num_Papeleta";
            this.numPapeletaDataGridViewTextBoxColumn.Name = "numPapeletaDataGridViewTextBoxColumn";
            // 
            // fecPapeletaDataGridViewTextBoxColumn
            // 
            this.fecPapeletaDataGridViewTextBoxColumn.DataPropertyName = "Fec_Papeleta";
            this.fecPapeletaDataGridViewTextBoxColumn.HeaderText = "Fec_Papeleta";
            this.fecPapeletaDataGridViewTextBoxColumn.Name = "fecPapeletaDataGridViewTextBoxColumn";
            // 
            // codInfraccionDataGridViewTextBoxColumn
            // 
            this.codInfraccionDataGridViewTextBoxColumn.DataPropertyName = "Cod_Infraccion";
            this.codInfraccionDataGridViewTextBoxColumn.HeaderText = "Cod_Infraccion";
            this.codInfraccionDataGridViewTextBoxColumn.Name = "codInfraccionDataGridViewTextBoxColumn";
            // 
            // numPlacaDataGridViewTextBoxColumn
            // 
            this.numPlacaDataGridViewTextBoxColumn.DataPropertyName = "Num_Placa";
            this.numPlacaDataGridViewTextBoxColumn.HeaderText = "Num_Placa";
            this.numPlacaDataGridViewTextBoxColumn.Name = "numPlacaDataGridViewTextBoxColumn";
            // 
            // estPapeletaDataGridViewTextBoxColumn
            // 
            this.estPapeletaDataGridViewTextBoxColumn.DataPropertyName = "Est_Papeleta";
            this.estPapeletaDataGridViewTextBoxColumn.HeaderText = "Est_Papeleta";
            this.estPapeletaDataGridViewTextBoxColumn.Name = "estPapeletaDataGridViewTextBoxColumn";
            // 
            // WindowsFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 394);
            this.Controls.Add(this.btnFechas);
            this.Controls.Add(this.dtgListadoFechas);
            this.Controls.Add(this.dtpFecfin);
            this.Controls.Add(this.dtpFecini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "WindowsFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de papeletas por fechas";
            this.Load += new System.EventHandler(this.WindowsFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListadoFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infraccionesFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPapeletaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecini;
        private System.Windows.Forms.DateTimePicker dtpFecfin;
        private System.Windows.Forms.DataGridView dtgListadoFechas;
        private System.Windows.Forms.Button btnFechas;
        private InfraccionesFechas infraccionesFechas;
        private System.Windows.Forms.BindingSource tbPapeletaBindingSource;
        private InfraccionesFechasTableAdapters.Tb_PapeletaTableAdapter tb_PapeletaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPapeletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecPapeletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codInfraccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estPapeletaDataGridViewTextBoxColumn;
    }
}