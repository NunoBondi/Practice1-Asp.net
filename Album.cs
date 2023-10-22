using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea1
{
    public class Album
    {
      public int Id { get; set; }
      public string Nombre { get; set; }
      public int IdArtista { get; set; }

        public Album(int id, string nombre, int idArtista)
        {
            Id = id;
            Nombre = nombre;
            IdArtista = idArtista;
        }
    }


}