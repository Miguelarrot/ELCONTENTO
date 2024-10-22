using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELCONTENTO
{
    public partial class Logueo : Form
    {
        string url = "http://localhost:50823/Api/Usuarios";

        public Logueo()
        {
            InitializeComponent();
        }

        private void BTsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTborrar_Click(object sender, EventArgs e)
        {
            TXcarnet.Clear();
            TXcon.Clear();
        }

        private void BTiniciarSesion_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(TXcarnet.Text)) || (String.IsNullOrEmpty(TXcon.Text)))
            {
                MessageBox.Show("Debe ingresar la información solicitada");

            }
            else
            {
                dynamic respuesta = BDApi.Get(url);
                string datosJson = respuesta.ToString();
                string[] vectordatos = datosJson.Split('}');
                int tam = vectordatos.Length;
                int carnet = Int32.Parse(TXcarnet.Text);
                string contraseña = TXcon.Text;
                Principal objprincipal;
                bool t = false;
                int i;
                for (i = 0; i < tam - 1; i++)
                {
                    if (carnet == Int32.Parse(respuesta[i].CARNET.ToString()))
                    {

                        if (contraseña.Equals(respuesta[i].CLAVE.ToString()))
                        {
                            MessageBox.Show("bienvenido");
                            t = true;
                            break;

                        }
                    }

                }
                if (t == false)
                    MessageBox.Show("el usuario no existe");
                else
                { 
                objprincipal = new Principal(carnet, Int32.Parse(respuesta[i].ROL.ToString()));
                objprincipal.Show();
            }
                    
                
            }
        }

        private void Logueo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eLCONTENTODataSet.PERIODO' Puede moverla o quitarla según sea necesario.
            this.pERIODOTableAdapter.Fill(this.eLCONTENTODataSet.PERIODO);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
