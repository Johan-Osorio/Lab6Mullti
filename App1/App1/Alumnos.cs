using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Alumnos
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FullName
        {
            get
            {
                return $"{Apellido}, {Nombre}";
            }
        }
    }
}
