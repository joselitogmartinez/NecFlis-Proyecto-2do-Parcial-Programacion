using System;

namespace Necflis
{
    class Usuario{
        public string nombre;
        public string direccion;
        public int edad;

        public Usuario(string nombre, string direccion, int edad){
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }
        public Usuario(){
            System.Console.WriteLine("______________________________");
            System.Console.WriteLine("Nombre del Cliente");
            nombre = Console.ReadLine();
                                            
            System.Console.WriteLine("\nDirecion del cliente");
            direccion = Console.ReadLine();

            System.Console.WriteLine("\nEdad del cliente");
            edad=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("\n¡Cliente ingresado con exito!");
            System.Console.WriteLine("______________________________");
            Console.ReadLine(); Console.Clear();

        }
    }
}
