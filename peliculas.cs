using System;

namespace Necflis
{
    class Peliculas{
        public string nombre;
        public string tipo;
        public string genero;
        public string sinopsis;
        public Peliculas(string nombre, string tipo, string genero, string sinopsis){
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.sinopsis = sinopsis;
        }

        public Peliculas(){
            System.Console.WriteLine("Nombre de la Pelicula");
            nombre = Console.ReadLine();
            System.Console.WriteLine("\nElegir tipo");
            System.Console.WriteLine("1- Serie");
            System.Console.WriteLine("2- Pelicula");
            tipo = Console.ReadLine();
            System.Console.WriteLine("\nTipo de Género");
            System.Console.WriteLine("1- drama");
            System.Console.WriteLine("2- comedia");
            System.Console.WriteLine("3- terror");
            System.Console.WriteLine("4- suspenso");
            genero =Console.ReadLine();
            System.Console.WriteLine("\nEscriba la sinopsis de la pelicula");
            sinopsis = Console.ReadLine();
            Console.Clear();
        }
    }
}