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
    public partial class actualizarEstudiante : Form
    {
        public actualizarEstudiante()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txcarnet.Clear();
            txNUEVO.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection objconectar = ControlBD.conectar("ELCONTENTO");
            if (CBact.Text.Equals("NOMBRE"))
            {
                string instruccion = "update PERSONAS set NOMBRE ='" + txNUEVO.Text + "'" + " where CARNET = " + Txcarnet.Text;
                int n = ControlBD.actualizar(instruccion, objconectar);
                if (n == 0)
                {
                    MessageBox.Show("falló la operación");
                }
                else
                {
                    MessageBox.Show("Actualización realizada con exito.");
                }
            }
            else
            {
                string instruccion = "update PERSONAS set " + CBact.Text + "=" + txNUEVO.Text + " where CARNET = " + Txcarnet.Text;

                int n = ControlBD.actualizar(instruccion, objconectar);
                if (n == 0)
                {
                    MessageBox.Show("falló la operación");
                }
                else
                {
                    MessageBox.Show("Actualización realizada con exito.");
                }
            }
        }
    }
}
