namespace ELCONTENTO
{
    partial class VISTA
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
            this.elcontentoDataSet1 = new ELCONTENTO.ELCONTENTODataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eLCONTENTODataSet11 = new ELCONTENTO.ELCONTENTODataSet1();
            this.eSTUDIANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTUDIANTETableAdapter = new ELCONTENTO.ELCONTENTODataSet1TableAdapters.ESTUDIANTETableAdapter();
            this.cARNETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODGRUPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.elcontentoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // elcontentoDataSet1
            // 
            this.elcontentoDataSet1.DataSetName = "ELCONTENTODataSet";
            this.elcontentoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cARNETDataGridViewTextBoxColumn,
            this.cODGRUPODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eSTUDIANTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(557, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // eLCONTENTODataSet11
            // 
            this.eLCONTENTODataSet11.DataSetName = "ELCONTENTODataSet1";
            this.eLCONTENTODataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTUDIANTEBindingSource
            // 
            this.eSTUDIANTEBindingSource.DataMember = "ESTUDIANTE";
            this.eSTUDIANTEBindingSource.DataSource = this.eLCONTENTODataSet11;
            // 
            // eSTUDIANTETableAdapter
            // 
            this.eSTUDIANTETableAdapter.ClearBeforeFill = true;
            // 
            // cARNETDataGridViewTextBoxColumn
            // 
            this.cARNETDataGridViewTextBoxColumn.DataPropertyName = "CARNET";
            this.cARNETDataGridViewTextBoxColumn.HeaderText = "CARNET";
            this.cARNETDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cARNETDataGridViewTextBoxColumn.Name = "cARNETDataGridViewTextBoxColumn";
            this.cARNETDataGridViewTextBoxColumn.Width = 150;
            // 
            // cODGRUPODataGridViewTextBoxColumn
            // 
            this.cODGRUPODataGridViewTextBoxColumn.DataPropertyName = "CODGRUPO";
            this.cODGRUPODataGridViewTextBoxColumn.HeaderText = "CODGRUPO";
            this.cODGRUPODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cODGRUPODataGridViewTextBoxColumn.Name = "cODGRUPODataGridViewTextBoxColumn";
            this.cODGRUPODataGridViewTextBoxColumn.Width = 150;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.Width = 150;
            // 
            // VISTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VISTA";
            this.Text = "VISTA";
            this.Load += new System.EventHandler(this.VISTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elcontentoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ELCONTENTODataSet elcontentoDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ELCONTENTODataSet1 eLCONTENTODataSet11;
        private System.Windows.Forms.BindingSource eSTUDIANTEBindingSource;
        private ELCONTENTODataSet1TableAdapters.ESTUDIANTETableAdapter eSTUDIANTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARNETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGRUPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
    }
}