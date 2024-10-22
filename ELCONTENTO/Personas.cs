using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELCONTENTO
{
    public class Personas
    {
        int carnet;
        string nombre;
        int edad;
        int rol;
        

        public Personas(int carnet)
        {
            this.carnet = carnet;
            this.nombre = "";
            this.edad = 0;
        }


        public int Carnet { get => carnet; set => carnet = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Rol { get => rol; set => rol = value; }


    }

}
