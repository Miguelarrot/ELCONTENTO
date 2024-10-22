using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ELCONTENTO
{
    public partial class consultaCodigo : Form
    {
        public consultaCodigo()
        {
            InitializeComponent();
        }

        private void BTenviar_Click(object sender, EventArgs e)
        {
            SqlConnection objConectar = new SqlConnection("Data Source=localhost;Initial Catalog=ELCONTENTO;Integrated Security=SSPI;");
            try
            {
                objConectar.Open();
                int cod = Int32.Parse(TXcod.Text);
                string instruccion = "select * from PERSONAS P inner join ESTUDIANTES E on P.CARNET = E.CARNET where E.CARNET = " + cod;
                SqlCommand objInstruccion = new SqlCommand(instruccion, objConectar);
                try
                {
                    SqlDataReader objTabla = objInstruccion.ExecuteReader();
                    if (objTabla.Read())
                    {
                        TXconsulta.Text=( "Carnet: "+ objTabla["CARNET"].ToString()+
                            "\n  Nombre: "+ objTabla["NOMBRE"].ToString() +
                            "\n  Edad: "+objTabla["EDAD"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");
                        TXconsulta.Clear();
                        
                    }
                    objConectar.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            TXconsulta.Clear();
            TXcod.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
