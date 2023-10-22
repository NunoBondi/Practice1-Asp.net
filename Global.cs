using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea1
{
    public class Global
    {

        public static List<Artista> Artistas = new List<Artista>()
        {
            new Artista(1,"Eddy Herrera", "14 Septiembre 1976"),
            new Artista(2,"Pedro Infante", "20 Octubre 1980"),
            new Artista(3,"Sean Paul", "1 Enero 1977"),
            new Artista(4,"Enrique Mejia", "6 Julio 1963"),
            new Artista(5,"Alejandro Fernandez", "19 Noviembre 1993"),
        };

        public static List<Cancion> Canciones = new List<Cancion>()
        {
        // Canciones de Eddy Herrera
        new Cancion(1, "Baila Morena", "4:15", "Merengue", 1),
        new Cancion(2, "Carolina", "3:45", "Merengue", 1),
        new Cancion(3, "Para Toda la Vida", "4:30", "Merengue", 1),

        // Canciones de Pedro Infante
        new Cancion(4, "Cien Años", "3:20", "Ranchera", 2),
        new Cancion(5, "Amorcito Corazón", "3:15", "Ranchera", 2),
        new Cancion(6, "Que Bonita es mi Tierra", "4:00", "Ranchera", 2),

        // Canciones de Sean Paul
        new Cancion(7, "Temperature", "3:37", "Dancehall", 3),
        new Cancion(8, "Get Busy", "3:31", "Dancehall", 3),
        new Cancion(9, "Like Glue", "3:54", "Dancehall", 3),

        // Canciones de Enrique Mejia
        new Cancion(10, "Soy Feliz", "3:10", "Balada", 4),
        new Cancion(11, "Mi Amor Es un Fantasma", "3:45", "Balada", 4),
        new Cancion(12, "La Cima del Cielo", "4:20", "Balada", 4),

        // Canciones de Alejandro Fernandez
        new Cancion(13, "Me Dedique a Perderte", "3:55", "Ranchera", 5),
        new Cancion(14, "Canta Corazón", "4:10", "Ranchera", 5),
        new Cancion(15, "Equivocadamente", "3:30", "Ranchera", 5),
    
    };

        public static List<Album> Albumes = new List<Album>()
        {
          
            new Album(1, "Álbum de Eddy Herrera", 1), 
            new Album(2, "Álbum de Pedro Infante", 2), 
            new Album(3, "Álbum de Sean Paul", 3), 
            new Album(4, "Álbum de Enrique Mejia", 4), 
            new Album(5, "Álbum de Alejandro Fernandez", 5) 
        };
    }
}