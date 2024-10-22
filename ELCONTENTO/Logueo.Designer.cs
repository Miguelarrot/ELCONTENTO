namespace ELCONTENTO
{
    partial class Logueo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXcarnet = new System.Windows.Forms.TextBox();
            this.TXcon = new System.Windows.Forms.TextBox();
            this.BTiniciarSesion = new System.Windows.Forms.Button();
            this.BTborrar = new System.Windows.Forms.Button();
            this.BTsalir = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.CBperiodo = new System.Windows.Forms.ComboBox();
            this.pERIODOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLCONTENTODataSet = new ELCONTENTO.ELCONTENTODataSet();
            this.pERIODOTableAdapter = new ELCONTENTO.ELCONTENTODataSetTableAdapters.PERIODOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pERIODOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de información académica el contento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(141, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carnet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(99, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // TXcarnet
            // 
            this.TXcarnet.BackColor = System.Drawing.SystemColors.Window;
            this.TXcarnet.Cursor = System.Windows.Forms.Cursors.Default;
            this.TXcarnet.ForeColor = System.Drawing.Color.DimGray;
            this.TXcarnet.Location = new System.Drawing.Point(273, 152);
            this.TXcarnet.Name = "TXcarnet";
            this.TXcarnet.Size = new System.Drawing.Size(143, 26);
            this.TXcarnet.TabIndex = 3;
            // 
            // TXcon
            // 
            this.TXcon.Location = new System.Drawing.Point(271, 201);
            this.TXcon.Name = "TXcon";
            this.TXcon.PasswordChar = '*';
            this.TXcon.Size = new System.Drawing.Size(143, 26);
            this.TXcon.TabIndex = 4;
            // 
            // BTiniciarSesion
            // 
            this.BTiniciarSesion.BackColor = System.Drawing.Color.Azure;
            this.BTiniciarSesion.Location = new System.Drawing.Point(534, 147);
            this.BTiniciarSesion.Name = "BTiniciarSesion";
            this.BTiniciarSesion.Size = new System.Drawing.Size(161, 46);
            this.BTiniciarSesion.TabIndex = 5;
            this.BTiniciarSesion.Text = "Iniciar sesión";
            this.BTiniciarSesion.UseVisualStyleBackColor = false;
            this.BTiniciarSesion.Click += new System.EventHandler(this.BTiniciarSesion_Click);
            // 
            // BTborrar
            // 
            this.BTborrar.Location = new System.Drawing.Point(534, 214);
            this.BTborrar.Name = "BTborrar";
            this.BTborrar.Size = new System.Drawing.Size(161, 48);
            this.BTborrar.TabIndex = 6;
            this.BTborrar.Text = "Borrar";
            this.BTborrar.UseVisualStyleBackColor = true;
            this.BTborrar.Click += new System.EventHandler(this.BTborrar_Click);
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(534, 292);
            this.BTsalir.Name = "BTsalir";
            this.BTsalir.Size = new System.Drawing.Size(161, 48);
            this.BTsalir.TabIndex = 7;
            this.BTsalir.Text = "Salir";
            this.BTsalir.UseVisualStyleBackColor = true;
            this.BTsalir.Click += new System.EventHandler(this.BTsalir_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(229, 327);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(217, 26);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvidé mi contraseña";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(128, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Periodo";
            // 
            // CBperiodo
            // 
            this.CBperiodo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pERIODOBindingSource, "PERIODO", true));
            this.CBperiodo.DataSource = this.pERIODOBindingSource;
            this.CBperiodo.DisplayMember = "PERIODO";
            this.CBperiodo.FormattingEnabled = true;
            this.CBperiodo.Location = new System.Drawing.Point(273, 267);
            this.CBperiodo.Name = "CBperiodo";
            this.CBperiodo.Size = new System.Drawing.Size(141, 28);
            this.CBperiodo.TabIndex = 10;
            this.CBperiodo.ValueMember = "IDPERIODO";
            // 
            // pERIODOBindingSource
            // 
            this.pERIODOBindingSource.DataMember = "PERIODO";
            this.pERIODOBindingSource.DataSource = this.eLCONTENTODataSet;
            // 
            // eLCONTENTODataSet
            // 
            this.eLCONTENTODataSet.DataSetName = "ELCONTENTODataSet";
            this.eLCONTENTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERIODOTableAdapter
            // 
            this.pERIODOTableAdapter.ClearBeforeFill = true;
            // 
            // Logueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBperiodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BTsalir);
            this.Controls.Add(this.BTborrar);
            this.Controls.Add(this.BTiniciarSesion);
            this.Controls.Add(this.TXcon);
            this.Controls.Add(this.TXcarnet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Logueo";
            this.Text = "Logueo";
            this.Load += new System.EventHandler(this.Logueo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pERIODOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLCONTENTODataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXcarnet;
        private System.Windows.Forms.TextBox TXcon;
        private System.Windows.Forms.Button BTiniciarSesion;
        private System.Windows.Forms.Button BTborrar;
        private System.Windows.Forms.Button BTsalir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBperiodo;
        private ELCONTENTODataSet eLCONTENTODataSet;
        private System.Windows.Forms.BindingSource pERIODOBindingSource;
        private ELCONTENTODataSetTableAdapters.PERIODOTableAdapter pERIODOTableAdapter;
    }
}

