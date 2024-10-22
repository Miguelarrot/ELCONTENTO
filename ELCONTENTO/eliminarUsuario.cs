using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELCONTENTO
{
    public partial class eliminarUsuario : Form
    {
        public eliminarUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXcarnet.Clear();
        }

        private void BTenviar_Click(object sender, EventArgs e)
        {
            SqlConnection objconectar = ControlBD.conectar("ELCONTENTO");

            string instruccion = "delete from ESTUDIANTES WHERE CARNET = " +TXcarnet.Text;

            int n = ControlBD.actualizar(instruccion, objconectar);
            if (n == 0)
            {
                MessageBox.Show("Estudiante no encontrado");
            }
            else
            {
                MessageBox.Show("usuario eliminado de la tabla estudiantes.");
            }

            instruccion = "delete from USUARIOS WHERE CARNET = " + TXcarnet.Text;
             n = ControlBD.actualizar(instruccion, objconectar);
            if (n == 0)
            {
                MessageBox.Show("falló la operación");
            }
            else
            {
                MessageBox.Show("usuario eliminado de la tabla USUARIOS.");
            }
            instruccion = "delete from PERSONAS WHERE CARNET = " + TXcarnet.Text;
            n = ControlBD.actualizar(instruccion, objconectar);
            if (n == 0)
            {
                MessageBox.Show("falló la operación");
            }
            else
            {
                MessageBox.Show("usuario eliminado de la tabla personas.");
            }
        }
    }
}
