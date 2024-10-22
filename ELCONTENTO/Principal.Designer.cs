namespace ELCONTENTO
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEstudiianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.actualizarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNotasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularDefinitivaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.verNotasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaMenu,
            this.actualizaciónMenu,
            this.ingresarNotasMenu,
            this.calcularDefinitivaMenu,
            this.verNotasMenu,
            this.salirMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaMenu
            // 
            this.consultaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPorCodigoToolStripMenuItem,
            this.toolStripSeparator1,
            this.consultaPorNombreToolStripMenuItem});
            this.consultaMenu.Name = "consultaMenu";
            this.consultaMenu.Size = new System.Drawing.Size(97, 29);
            this.consultaMenu.Text = "Consulta";
            // 
            // consultaPorCodigoToolStripMenuItem
            // 
            this.consultaPorCodigoToolStripMenuItem.Name = "consultaPorCodigoToolStripMenuItem";
            this.consultaPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.consultaPorCodigoToolStripMenuItem.Text = "Consulta por codigo";
            this.consultaPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.consultaPorCodigoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(281, 6);
            // 
            // consultaPorNombreToolStripMenuItem
            // 
            this.consultaPorNombreToolStripMenuItem.Name = "consultaPorNombreToolStripMenuItem";
            this.consultaPorNombreToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.consultaPorNombreToolStripMenuItem.Text = "Consulta por nombre";
            this.consultaPorNombreToolStripMenuItem.Click += new System.EventHandler(this.consultaPorNombreToolStripMenuItem_Click);
            // 
            // actualizaciónMenu
            // 
            this.actualizaciónMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEstudiianteToolStripMenuItem,
            this.toolStripSeparator2,
            this.eliminarEstudianteToolStripMenuItem,
            this.toolStripSeparator3,
            this.actualizarDatosToolStripMenuItem});
            this.actualizaciónMenu.Name = "actualizaciónMenu";
            this.actualizaciónMenu.Size = new System.Drawing.Size(131, 29);
            this.actualizaciónMenu.Text = "Actualización";
            // 
            // ingresarEstudiianteToolStripMenuItem
            // 
            this.ingresarEstudiianteToolStripMenuItem.Name = "ingresarEstudiianteToolStripMenuItem";
            this.ingresarEstudiianteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ingresarEstudiianteToolStripMenuItem.Text = "Ingresar estudiante";
            this.ingresarEstudiianteToolStripMenuItem.Click += new System.EventHandler(this.ingresarEstudiianteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // eliminarEstudianteToolStripMenuItem
            // 
            this.eliminarEstudianteToolStripMenuItem.Name = "eliminarEstudianteToolStripMenuItem";
            this.eliminarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarEstudianteToolStripMenuItem.Text = "Eliminar estudiante";
            this.eliminarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.eliminarEstudianteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // actualizarDatosToolStripMenuItem
            // 
            this.actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            this.actualizarDatosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.actualizarDatosToolStripMenuItem.Text = "Actualizar datos";
            this.actualizarDatosToolStripMenuItem.Click += new System.EventHandler(this.actualizarDatosToolStripMenuItem_Click);
            // 
            // ingresarNotasMenu
            // 
            this.ingresarNotasMenu.Name = "ingresarNotasMenu";
            this.ingresarNotasMenu.Size = new System.Drawing.Size(141, 29);
            this.ingresarNotasMenu.Text = "Ingresar notas";
            // 
            // calcularDefinitivaMenu
            // 
            this.calcularDefinitivaMenu.Name = "calcularDefinitivaMenu";
            this.calcularDefinitivaMenu.Size = new System.Drawing.Size(168, 29);
            this.calcularDefinitivaMenu.Text = "Calcular Definitiva";
            // 
            // salirMenu
            // 
            this.salirMenu.Name = "salirMenu";
            this.salirMenu.Size = new System.Drawing.Size(61, 29);
            this.salirMenu.Text = "Salir";
            // 
            // verNotasMenu
            // 
            this.verNotasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistaToolStripMenuItem,
            this.maestroDetalleToolStripMenuItem});
            this.verNotasMenu.Name = "verNotasMenu";
            this.verNotasMenu.Size = new System.Drawing.Size(100, 32);
            this.verNotasMenu.Text = "Asistente";
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.vistaToolStripMenuItem.Text = "Vista";
            this.vistaToolStripMenuItem.Click += new System.EventHandler(this.vistaToolStripMenuItem_Click);
            // 
            // maestroDetalleToolStripMenuItem
            // 
            this.maestroDetalleToolStripMenuItem.Name = "maestroDetalleToolStripMenuItem";
            this.maestroDetalleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.maestroDetalleToolStripMenuItem.Text = "Maestro detalle";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaMenu;
        private System.Windows.Forms.ToolStripMenuItem consultaPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem consultaPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónMenu;
        private System.Windows.Forms.ToolStripMenuItem ingresarEstudiianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem eliminarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNotasMenu;
        private System.Windows.Forms.ToolStripMenuItem calcularDefinitivaMenu;
        private System.Windows.Forms.ToolStripMenuItem salirMenu;
        private System.Windows.Forms.ToolStripMenuItem verNotasMenu;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestroDetalleToolStripMenuItem;
    }
}