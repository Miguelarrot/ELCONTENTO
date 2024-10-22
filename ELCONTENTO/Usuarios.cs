using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELCONTENTO
{
    internal class Usuarios
    {
        int CARNET;
         string CLAVE;
        int ROL;
         string PREGUNTA;
        string RESPUESTA;

        public Usuarios()
        {
        }

        public Usuarios(int carnet, string contraseña, int rol, string pregunta, string respuesta)
        {
            this.CARNET = carnet;
            this.CLAVE = contraseña;
            this.ROL = rol;
            this.PREGUNTA = pregunta;
            this.RESPUESTA = respuesta;
        }

        public int Carnet { get => CARNET; set => CARNET = value; }
        public string Clave { get => CLAVE; set => CLAVE = value; }
        public int Rol { get => ROL; set => ROL = value; }
        public string Pregunta { get => PREGUNTA; set => PREGUNTA = value; }
        public string Respuesta { get => RESPUESTA; set => RESPUESTA = value; }
    }
}
