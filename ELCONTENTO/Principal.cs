using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELCONTENTO
{
    public partial class Principal : Form
    {
        
        public Principal(int carnet, int rol)
        {
            InitializeComponent();
            Personas user = new Personas(carnet);
            if(rol == 3)
            {
                ingresarNotasMenu.Enabled = false;
                calcularDefinitivaMenu.Enabled = false;
                verNotasMenu.Enabled = false;
            }
            if(rol == 2)
            {
                actualizaciónMenu.Enabled = false;
                verNotasMenu.Enabled=false;

            }
            if(rol == 1)
            {
                ingresarNotasMenu.Enabled = false;
                calcularDefinitivaMenu.Enabled = false;
                actualizaciónMenu.Enabled=false;
                consultaMenu.Enabled=false;
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
          
            
        }

        private void consultaPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaCodigo objcod = new consultaCodigo();
            objcod.MdiParent = this;
            objcod.Show();
        }

        private void consultaPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaNombre objnom = new consultaNombre();
            objnom.MdiParent = this;
            objnom.Show();
        }

        private void ingresarEstudiianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresarEstudiante obji = new ingresarEstudiante();
            obji.MdiParent = this;
            obji.Show();
        }

        private void eliminarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarUsuario objeliminar = new eliminarUsuario();
            objeliminar.MdiParent = this;
            objeliminar.Show();
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarEstudiante objacto = new actualizarEstudiante();
            objacto.MdiParent = this;

            objacto.Show();
        }

        private void vistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VISTA objvista = new VISTA();
            objvista.MdiParent = this;
            objvista.Show();
        }
    }
}
