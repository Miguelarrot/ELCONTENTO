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
    public partial class consultaNombre : Form
    {
        public consultaNombre()
        {
            InitializeComponent();
        }

        private void BTsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTborrar_Click(object sender, EventArgs e)
        {
            txcarnet.Clear();
            txnom.Clear();
            TXconsulta.Clear();
            txedad.Clear();
        }

        private void BTenviar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = new SqlConnection("Data Source=localhost;Initial Catalog=ELCONTENTO;Integrated Security=SSPI;");
            try
            {
                objConectar.Open();
                string nom = TXconsulta.Text;
                string instruccion = "select * from PERSONAS where NOMBRE = '" + nom+"'";
                SqlCommand objInstruccion = new SqlCommand(instruccion, objConectar);
                try
                {
                    SqlDataReader objTabla = objInstruccion.ExecuteReader();
                    if (objTabla.Read())
                    {
                        txcarnet.Text = objTabla["CARNET"].ToString();
                        txnom.Text = objTabla["NOMBRE"].ToString();
                        txedad.Text = objTabla["EDAD"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");
                        TXconsulta.Clear();


                    }
                }
                catch (SqlException er)
                {
                    MessageBox.Show("Falló la consulta " + er.Message);
                }

            }
            catch (SqlException es)
            {
                MessageBox.Show("falló la conexión a la base de datos" + es.Message);
            }
        }
    }
}
