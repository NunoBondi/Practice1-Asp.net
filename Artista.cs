using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea1
{
    public class Artista
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string FechaNacimiento { get; set; }

        public Artista(int id, string nombreCompleto, string fechaNacimiento)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
        }
    }

}