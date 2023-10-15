using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class AlumnosGroup: List<Alumnos>
    {
        public string Heading { get; set; }
        public List<Alumnos> Alumnos => this;
    }
}
