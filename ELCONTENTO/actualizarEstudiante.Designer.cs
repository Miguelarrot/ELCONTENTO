﻿namespace ELCONTENTO
{
    partial class actualizarEstudiante
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
            this.Txcarnet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBact = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txNUEVO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el carnet del estudiante a actualizar";
            // 
            // Txcarnet
            // 
            this.Txcarnet.Location = new System.Drawing.Point(511, 114);
            this.Txcarnet.Name = "Txcarnet";
            this.Txcarnet.Size = new System.Drawing.Size(190, 26);
            this.Txcarnet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "¿qué se actualizará?";
            // 
            // CBact
            // 
            this.CBact.FormattingEnabled = true;
            this.CBact.Items.AddRange(new object[] {
            "NOMBRE",
            "EDAD"});
            this.CBact.Location = new System.Drawing.Point(511, 191);
            this.CBact.Name = "CBact";
            this.CBact.Size = new System.Drawing.Size(190, 28);
            this.CBact.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nuevo valor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txNUEVO
            // 
            this.txNUEVO.Location = new System.Drawing.Point(511, 254);
            this.txNUEVO.Name = "txNUEVO";
            this.txNUEVO.Size = new System.Drawing.Size(190, 26);
            this.txNUEVO.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 60);
            this.button2.TabIndex = 9;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(542, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 60);
            this.button3.TabIndex = 10;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // actualizarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txNUEVO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txcarnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "actualizarEstudiante";
            this.Text = "actualizarEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txcarnet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txNUEVO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}