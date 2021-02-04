using System;

namespace MarisolWeb.Controllers
{
    internal class Enfermero
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int Cedula { get; set; }
        public string lugtabajo { get; set; }
        public string salario { get; set; }
        public string horario { get; set; }
        public string Resultado { get; set; }
        public void CrearEnfermero()
        {
            Resultado = (nombre + " " + apellido + " " + Cedula + " " + lugtabajo + " " + salario + " " + horario);
        }
    }
}
    