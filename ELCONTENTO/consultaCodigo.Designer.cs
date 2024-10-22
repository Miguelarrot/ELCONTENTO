namespace ELCONTENTO
{
    partial class consultaCodigo
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
            this.TXcod = new System.Windows.Forms.TextBox();
            this.BTenviar = new System.Windows.Forms.Button();
            this.TXconsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(233, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta por código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(106, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el código";
            // 
            // TXcod
            // 
            this.TXcod.Location = new System.Drawing.Point(385, 115);
            this.TXcod.Name = "TXcod";
            this.TXcod.Size = new System.Drawing.Size(206, 26);
            this.TXcod.TabIndex = 2;
            // 
            // BTenviar
            // 
            this.BTenviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTenviar.Location = new System.Drawing.Point(200, 171);
            this.BTenviar.Name = "BTenviar";
            this.BTenviar.Size = new System.Drawing.Size(123, 49);
            this.BTenviar.TabIndex = 3;
            this.BTenviar.Text = "Enviar";
            this.BTenviar.UseVisualStyleBackColor = true;
            this.BTenviar.Click += new System.EventHandler(this.BTenviar_Click);
            // 
            // TXconsulta
            // 
            this.TXconsulta.Location = new System.Drawing.Point(111, 258);
            this.TXconsulta.Multiline = true;
            this.TXconsulta.Name = "TXconsulta";
            this.TXconsulta.Size = new System.Drawing.Size(570, 155);
            this.TXconsulta.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(358, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(528, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // consultaCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXconsulta);
            this.Controls.Add(this.BTenviar);
            this.Controls.Add(this.TXcod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "consultaCodigo";
            this.Text = "consultaCodigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXcod;
        private System.Windows.Forms.Button BTenviar;
        private System.Windows.Forms.TextBox TXconsulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}