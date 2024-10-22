namespace ELCONTENTO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eLCONTENTODataSet2 = new ELCONTENTO.ELCONTENTODataSet2();
            this.eSTUDIANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTUDIANTETableAdapter = new ELCONTENTO.ELCONTENTODataSet2TableAdapters.ESTUDIANTETableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eLCONTENTODataSet1 = new ELCONTENTO.ELCONTENTODataSet1();
            this.eLCONTENTODataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRUPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLCONTENTODataSet3 = new ELCONTENTO.ELCONTENTODataSet3();
            this.gRUPOTableAdapter = new ELCONTENTO.ELCONTENTODataSet3TableAdapters.GRUPOTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cARNETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODGRUPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERTENECENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLCONTENTODataSet4 = new ELCONTENTO.ELCONTENTODataSet4();
            this.pERTENECENTableAdapter = new ELCONTENTO.ELCONTENTODataSet4TableAdapters.PERTENECENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERTENECENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // eLCONTENTODataSet2
            // 
            this.eLCONTENTODataSet2.DataSetName = "ELCONTENTODataSet2";
            this.eLCONTENTODataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTUDIANTEBindingSource
            // 
            this.eSTUDIANTEBindingSource.DataMember = "ESTUDIANTE";
            this.eSTUDIANTEBindingSource.DataSource = this.eLCONTENTODataSet2;
            // 
            // eSTUDIANTETableAdapter
            // 
            this.eSTUDIANTETableAdapter.ClearBeforeFill = true;
            // 
            // eLCONTENTODataSet1
            // 
            this.eLCONTENTODataSet1.DataSetName = "ELCONTENTODataSet1";
            this.eLCONTENTODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLCONTENTODataSet1BindingSource
            // 
            this.eLCONTENTODataSet1BindingSource.DataSource = this.eLCONTENTODataSet1;
            this.eLCONTENTODataSet1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGODataGridViewTextBoxColumn,
            this.tEMADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gRUPOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(101, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(566, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cODIGODataGridViewTextBoxColumn
            // 
            this.cODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.cODIGODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cODIGODataGridViewTextBoxColumn.Name = "cODIGODataGridViewTextBoxColumn";
            this.cODIGODataGridViewTextBoxColumn.Width = 150;
            // 
            // tEMADataGridViewTextBoxColumn
            // 
            this.tEMADataGridViewTextBoxColumn.DataPropertyName = "TEMA";
            this.tEMADataGridViewTextBoxColumn.HeaderText = "TEMA";
            this.tEMADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tEMADataGridViewTextBoxColumn.Name = "tEMADataGridViewTextBoxColumn";
            this.tEMADataGridViewTextBoxColumn.Width = 150;
            // 
            // gRUPOBindingSource
            // 
            this.gRUPOBindingSource.DataMember = "GRUPO";
            this.gRUPOBindingSource.DataSource = this.eLCONTENTODataSet3;
            // 
            // eLCONTENTODataSet3
            // 
            this.eLCONTENTODataSet3.DataSetName = "ELCONTENTODataSet3";
            this.eLCONTENTODataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gRUPOTableAdapter
            // 
            this.gRUPOTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 38);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 33);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cARNETDataGridViewTextBoxColumn,
            this.cODGRUPODataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pERTENECENBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(101, 239);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(621, 150);
            this.dataGridView2.TabIndex = 2;
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
            // pERTENECENBindingSource
            // 
            this.pERTENECENBindingSource.DataMember = "PERTENECEN";
            this.pERTENECENBindingSource.DataSource = this.eLCONTENTODataSet4;
            // 
            // eLCONTENTODataSet4
            // 
            this.eLCONTENTODataSet4.DataSetName = "ELCONTENTODataSet4";
            this.eLCONTENTODataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERTENECENTableAdapter
            // 
            this.pERTENECENTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTUDIANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRUPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERTENECENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ELCONTENTODataSet2 eLCONTENTODataSet2;
        private System.Windows.Forms.BindingSource eSTUDIANTEBindingSource;
        private ELCONTENTODataSet2TableAdapters.ESTUDIANTETableAdapter eSTUDIANTETableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ELCONTENTODataSet1 eLCONTENTODataSet1;
        private System.Windows.Forms.BindingSource eLCONTENTODataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ELCONTENTODataSet3 eLCONTENTODataSet3;
        private System.Windows.Forms.BindingSource gRUPOBindingSource;
        private ELCONTENTODataSet3TableAdapters.GRUPOTableAdapter gRUPOTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ELCONTENTODataSet4 eLCONTENTODataSet4;
        private System.Windows.Forms.BindingSource pERTENECENBindingSource;
        private ELCONTENTODataSet4TableAdapters.PERTENECENTableAdapter pERTENECENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARNETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODGRUPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMADataGridViewTextBoxColumn;
    }
}