using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System.Net;
using System.Web;
using static System.Net.WebRequestMethods;
using System.Data.SqlClient;

namespace ELCONTENTO
{
    public partial class ingresarEstudiante : Form
    {
        string url = "http://localhost:50823/Api/Usuarios";
        public ingresarEstudiante()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTingresar_Click(object sender, EventArgs e)
        {
            SqlConnection objconectar = ControlBD.conectar("ELCONTENTO");

            string instruccion = "INSERT into PERSONAS VALUES (" +
            TXcarnet.Text + ", '" + TXnom.Text + "'," + TXedad.Text + ") ";

            int n = ControlBD.actualizar(instruccion, objconectar);
            if (n == 0)
            {
                MessageBox.Show("falló la operación");
            }
            else
            {
                MessageBox.Show("usuario agregado en la tabla personas.");
            }

            instruccion = "INSERT into ESTUDIANTES VALUES (" +
            TXcarnet.Text + ",null)";
            n = ControlBD.actualizar(instruccion, objconectar);
            if (n == 0)
            {
                MessageBox.Show("falló la operación");
            }
            else
            {
                MessageBox.Show("usuario agregado en la tabla estudiantes.");
            }

            instruccion = "INSERT into usuarios VALUES (" +
            TXcarnet.Text + ",'"+TXcontraseña.Text+"',1,'"+Txpre.Text+"','"+TXres.Text +"')";
            n = ControlBD.actualizar(instruccion, objconectar);
            if (n == 0)
            {
                MessageBox.Show("falló la operación");
            }
            else
            {
                MessageBox.Show("usuario agregado en la tabla usuarios.");
            }


        }
    }
}
