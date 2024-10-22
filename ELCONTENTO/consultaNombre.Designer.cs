namespace ELCONTENTO
{
    partial class consultaNombre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXconsulta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txcarnet = new System.Windows.Forms.TextBox();
            this.txnom = new System.Windows.Forms.TextBox();
            this.txedad = new System.Windows.Forms.TextBox();
            this.BTenviar = new System.Windows.Forms.Button();
            this.BTborrar = new System.Windows.Forms.Button();
            this.BTsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(234, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta por nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(136, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el nombre";
            // 
            // TXconsulta
            // 
            this.TXconsulta.Location = new System.Drawing.Point(363, 107);
            this.TXconsulta.Name = "TXconsulta";
            this.TXconsulta.Size = new System.Drawing.Size(202, 26);
            this.TXconsulta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(136, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(136, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(136, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Carnet";
            // 
            // txcarnet
            // 
            this.txcarnet.Location = new System.Drawing.Point(289, 186);
            this.txcarnet.Name = "txcarnet";
            this.txcarnet.Size = new System.Drawing.Size(100, 26);
            this.txcarnet.TabIndex = 6;
            // 
            // txnom
            // 
            this.txnom.Location = new System.Drawing.Point(289, 240);
            this.txnom.Name = "txnom";
            this.txnom.Size = new System.Drawing.Size(100, 26);
            this.txnom.TabIndex = 7;
            // 
            // txedad
            // 
            this.txedad.Location = new System.Drawing.Point(289, 298);
            this.txedad.Name = "txedad";
            this.txedad.Size = new System.Drawing.Size(100, 26);
            this.txedad.TabIndex = 8;
            // 
            // BTenviar
            // 
            this.BTenviar.Location = new System.Drawing.Point(665, 109);
            this.BTenviar.Name = "BTenviar";
            this.BTenviar.Size = new System.Drawing.Size(85, 40);
            this.BTenviar.TabIndex = 9;
            this.BTenviar.Text = "Enviar";
            this.BTenviar.UseVisualStyleBackColor = true;
            this.BTenviar.Click += new System.EventHandler(this.BTenviar_Click);
            // 
            // BTborrar
            // 
            this.BTborrar.Location = new System.Drawing.Point(665, 155);
            this.BTborrar.Name = "BTborrar";
            this.BTborrar.Size = new System.Drawing.Size(85, 42);
            this.BTborrar.TabIndex = 10;
            this.BTborrar.Text = "Borrar";
            this.BTborrar.UseVisualStyleBackColor = true;
            this.BTborrar.Click += new System.EventHandler(this.BTborrar_Click);
            // 
            // BTsalir
            // 
            this.BTsalir.Location = new System.Drawing.Point(665, 203);
            this.BTsalir.Name = "BTsalir";
            this.BTsalir.Size = new System.Drawing.Size(85, 34);
            this.BTsalir.TabIndex = 11;
            this.BTsalir.Text = "Salir";
            this.BTsalir.UseVisualStyleBackColor = true;
            this.BTsalir.Click += new System.EventHandler(this.BTsalir_Click);
            // 
            // consultaNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTsalir);
            this.Controls.Add(this.BTborrar);
            this.Controls.Add(this.BTenviar);
            this.Controls.Add(this.txedad);
            this.Controls.Add(this.txnom);
            this.Controls.Add(this.txcarnet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXconsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "consultaNombre";
            this.Text = "consultaNombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXconsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txcarnet;
        private System.Windows.Forms.TextBox txnom;
        private System.Windows.Forms.TextBox txedad;
        private System.Windows.Forms.Button BTenviar;
        private System.Windows.Forms.Button BTborrar;
        private System.Windows.Forms.Button BTsalir;
    }
}