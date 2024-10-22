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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eLCONTENTODataSet4.PERTENECEN' Puede moverla o quitarla según sea necesario.
            this.pERTENECENTableAdapter.Fill(this.eLCONTENTODataSet4.PERTENECEN);
            // TODO: esta línea de código carga datos en la tabla 'eLCONTENTODataSet3.GRUPO' Puede moverla o quitarla según sea necesario.
            this.gRUPOTableAdapter.Fill(this.eLCONTENTODataSet3.GRUPO);
            // TODO: esta línea de código carga datos en la tabla 'eLCONTENTODataSet2.ESTUDIANTE' Puede moverla o quitarla según sea necesario.
            this.eSTUDIANTETableAdapter.Fill(this.eLCONTENTODataSet2.ESTUDIANTE);

        }
    }
}
