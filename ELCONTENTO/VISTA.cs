﻿using System;
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
    public partial class VISTA : Form
    {
        public VISTA()
        {
            InitializeComponent();
        }

        private void VISTA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eLCONTENTODataSet11.ESTUDIANTE' Puede moverla o quitarla según sea necesario.
            this.eSTUDIANTETableAdapter.Fill(this.eLCONTENTODataSet11.ESTUDIANTE);

        }
    }
}
