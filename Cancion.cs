using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea1
{
    public class Cancion
    {
        public int Id { get; set; }
        public string NombreCancion { get; set; }
        public string Duracion { get; set; }
        public string Genero { get; set; }
        public int AlbumId { get; set; }

        public Cancion(int id, string nombreCancion, string duracion, string genero, int albumId) {
            Id = id;
            NombreCancion = nombreCancion;
            Duracion = duracion;
            Genero = genero;
            AlbumId = albumId;
        }
    }
}