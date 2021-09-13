namespace Test_Final
{
    partial class PapeletasImpagas
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
            this.txtPlacaII = new System.Windows.Forms.TextBox();
            this.dtgInfracciones01 = new System.Windows.Forms.DataGridView();
            this.infracciones01 = new Test_Final.Infracciones01();
            this.tbPapeletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_PapeletaTableAdapter = new Test_Final.Infracciones01TableAdapters.Tb_PapeletaTableAdapter();
            this.numPapeletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecPapeletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codInfraccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estPapeletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfracciones01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infracciones01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPapeletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de placa";
            // 
            // txtPlacaII
            // 
            this.txtPlacaII.Location = new System.Drawing.Point(45, 85);
            this.txtPlacaII.Name = "txtPlacaII";
            this.txtPlacaII.Size = new System.Drawing.Size(100, 20);
            this.txtPlacaII.TabIndex = 2;
            // 
            // dtgInfracciones01
            // 
            this.dtgInfracciones01.AutoGenerateColumns = false;
            this.dtgInfracciones01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfracciones01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numPapeletaDataGridViewTextBoxColumn,
            this.fecPapeletaDataGridViewTextBoxColumn,
            this.codInfraccionDataGridViewTextBoxColumn,
            this.numPlacaDataGridViewTextBoxColumn,
            this.estPapeletaDataGridViewTextBoxColumn});
            this.dtgInfracciones01.DataSource = this.tbPapeletaBindingSource;
            this.dtgInfracciones01.Location = new System.Drawing.Point(45, 144);
            this.dtgInfracciones01.Name = "dtgInfracciones01";
            this.dtgInfracciones01.Size = new System.Drawing.Size(542, 150);
            this.dtgInfracciones01.TabIndex = 3;
            // 
            // infracciones01
            // 
            this.infracciones01.DataSetName = "Infracciones01";
            this.infracciones01.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbPapeletaBindingSource
            // 
            this.tbPapeletaBindingSource.DataMember = "Tb_Papeleta";
            this.tbPapeletaBindingSource.DataSource = this.infracciones01;
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
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(484, 83);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // PapeletasImpagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 350);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dtgInfracciones01);
            this.Controls.Add(this.txtPlacaII);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "PapeletasImpagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listadod de papeletas Impagas";
            this.Load += new System.EventHandler(this.PapeletasImpagas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfracciones01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infracciones01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPapeletaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlacaII;
        private System.Windows.Forms.DataGridView dtgInfracciones01;
        private Infracciones01 infracciones01;
        private System.Windows.Forms.BindingSource tbPapeletaBindingSource;
        private Infracciones01TableAdapters.Tb_PapeletaTableAdapter tb_PapeletaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPapeletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecPapeletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codInfraccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estPapeletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnMostrar;
    }
}