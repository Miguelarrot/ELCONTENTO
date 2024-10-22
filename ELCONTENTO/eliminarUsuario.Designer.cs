namespace ELCONTENTO
{
    partial class eliminarUsuario
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
            this.TXcarnet = new System.Windows.Forms.TextBox();
            this.BTenviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el carnet del estudiante";
            // 
            // TXcarnet
            // 
            this.TXcarnet.Location = new System.Drawing.Point(407, 124);
            this.TXcarnet.Name = "TXcarnet";
            this.TXcarnet.Size = new System.Drawing.Size(210, 26);
            this.TXcarnet.TabIndex = 2;
            // 
            // BTenviar
            // 
            this.BTenviar.Location = new System.Drawing.Point(238, 237);
            this.BTenviar.Name = "BTenviar";
            this.BTenviar.Size = new System.Drawing.Size(83, 56);
            this.BTenviar.TabIndex = 3;
            this.BTenviar.Text = "Enviar";
            this.BTenviar.UseVisualStyleBackColor = true;
            this.BTenviar.Click += new System.EventHandler(this.BTenviar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTenviar);
            this.Controls.Add(this.TXcarnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "eliminarUsuario";
            this.Text = "eliminarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXcarnet;
        private System.Windows.Forms.Button BTenviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}