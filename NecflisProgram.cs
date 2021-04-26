using System;

namespace Necflis
{
    class NecflisProgram
    {
        static void Main(string[] args)
        {
            Usuario[] lista = new Usuario[15];
            Usuario usuario = new Usuario(null,null,0);
            Peliculas[] lista2 = new Peliculas[15];
            Peliculas peliculas = new Peliculas(null,null,null,null);
            registro registro = new registro(null,null,0);
            registro[] lista3 = new registro[30];
            string[] listaprueba = new string[10];
            int contador = 0;          
            int resultado = 0;
            int operacion = 0;
            int numero = 1 ;
            int valor = 0;
            int contar = 0;
            int num = 1;
            int sumatoria = 0;
            System.Console.WriteLine("______________________________");
            System.Console.WriteLine("    BIEVENIDO A NECFLIS");

            while (resultado!=3){
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("¿Qué deseas hacer?");
            System.Console.WriteLine("1. CLIENTES");
            System.Console.WriteLine("2. PELICULAS");
            System.Console.WriteLine("3. SALIR DE NECFLIS");
            System.Console.WriteLine("______________________________");

            resultado=Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch(resultado){
                case 1:
                    while(operacion!=4){
                        System.Console.WriteLine("_____________________________");
                        System.Console.WriteLine("          USUARIOS");
                        System.Console.WriteLine("Eliga una opcion...");
                        System.Console.WriteLine("1. Ver listado de clientes");
                        System.Console.WriteLine("2. Crear nuevo cliente");
                        System.Console.WriteLine("3. Selecionar cliente");
                        System.Console.WriteLine("4. Ir Atrás");
                        System.Console.WriteLine("______________________________");

                        operacion=Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch(operacion){
                            case 1:   
                                System.Console.WriteLine("______________________________");
                                System.Console.WriteLine("      LISTADO DE USUARIOS");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    System.Console.WriteLine("["+numero +"]. " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;
                                System.Console.WriteLine("______________________________");
                                Console.ReadLine(); Console.Clear();
                            break;
                            case 2:
                                usuario = new Usuario();
                                lista[contador] = usuario;
                                contador++;                   
                            break;

                            case 3:
                                System.Console.WriteLine("______________________________");
                                System.Console.WriteLine("Ingresar el numero del cliente");
                                int valor1 = Int32.Parse(Console.ReadLine());
                                Usuario usuario1 = lista[valor1 -1];
                                System.Console.WriteLine("\n      Informacion General");
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine("Nombre: "+ usuario1.nombre);
                                System.Console.WriteLine("Direccion: " + usuario1.direccion);
                                System.Console.WriteLine("Edad: " + usuario1.edad);
                                System.Console.WriteLine("______________________________");
                                Console.ReadLine(); Console.Clear();

                                while(true){
                                System.Console.WriteLine("______________________________");
                                System.Console.WriteLine("Escoja una de las opciones");
                                System.Console.WriteLine("1. PlayList");
                                System.Console.WriteLine("2. Agregar pelicula");
                                System.Console.WriteLine("3. Ir Atrás");
                                System.Console.WriteLine("______________________________");
                                int indice = Int32.Parse(Console.ReadLine());
                                Console.Clear();
                                


                                if (indice ==1){
                                    for (int i = 0; i < sumatoria; i++)
                                    {
                                    string valores = registro.lista[i];
                                    System.Console.WriteLine( num +" " + valores);
                                    num++;
                                    }
                                    num = 1;
                                    
                                }
                                if (indice ==2){
                                    while(true){
                                    System.Console.WriteLine("______________________________");
                                    System.Console.WriteLine("     Listado de Peliculas");
                                    for (int i = 0; i < contar; i++)
                                    {
                                        peliculas = lista2[i];
                                        System.Console.WriteLine( num +" " + peliculas.nombre);
                                        num++;
                                    }
                                    num = 1;
                                    System.Console.WriteLine("______________________________");
    
                                    System.Console.WriteLine("¿Qué pelicula desea agregar?");
                                    int escojer = Int32.Parse(Console.ReadLine());
                                    if(escojer==0){

                                        registro = new registro(usuario1.nombre,listaprueba);
                                        break;
                                        
                                    }
                                    
                                    else{
                                        peliculas = lista2[escojer-1];
                                        string peli = peliculas.nombre; 
                                        registro =new registro(usuario1.nombre,peli,sumatoria);
                                        lista3[sumatoria] = registro;
                                        sumatoria++;

                                    }

                                    for (int i = 0; i < sumatoria; i++)
                                    {
                                        registro=lista3[i];
                                        listaprueba[i] = registro.peliculas_usuario;
                                    }

                                    }

                                }
                                if (indice ==3){
                                    Console.Clear();
                                    break;
                                }
                                else{
                                    System.Console.WriteLine("\nEscoja uno de los valores");
                                    Console.ReadLine(); Console.Clear();
                                }
                                }
                                break; 
                                
                            case 4:
                                System.Console.WriteLine("\n\n\nSiga utilizando NECFLIS!!!");
                                Console.ReadLine(); Console.Clear();
                            break;                   
                            default:
                                System.Console.WriteLine("\nEscoja una de las opciones");
                            break;
                            }
                    }

                    break;
                case 2:
                    while(valor!=3){
                        System.Console.WriteLine("______________________________");
                        System.Console.WriteLine("          Peliculas");
                        System.Console.WriteLine("¿Qué desea hacer?");
                        System.Console.WriteLine("1. Ver el Listado de Peliculas");
                        System.Console.WriteLine("2. Crear peliculas");
                        System.Console.WriteLine("3. <<= Regresar");
                        System.Console.WriteLine("______________________________");

                        valor = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        switch(valor){
                            case 1: 
                            System.Console.WriteLine("______________________________");
                            System.Console.WriteLine("      Listado de peliculas");
                                for (int i = 0; i < contar; i++)
                                {
                                    peliculas = lista2[i];
                                    System.Console.WriteLine( num +" " + peliculas.nombre);
                                    num++;
                                }
                                num = 1;
                                Console.Write("\n\nPress... Enter para Continuar....");
                                Console.ReadLine();
                                Console.Clear();
                            break;

                            case 2:
                                peliculas = new Peliculas();
                                lista2[contar] = peliculas;
                                contar++; 
                            break;

                            case 3:
                                System.Console.WriteLine("\n\n\nGracias, siga disfrutando de NecFlis");
                                Console.ReadLine(); Console.Clear();
                            break;
                    
                            default:
                                System.Console.WriteLine("\nEliga una opcion valida...");
                            break;
                        }
                    }
                    break;
                case 3:
                    System.Console.WriteLine("\n\n\nGOODBYE!!! NECFLIS LO MEJOR EN ENTRETENIMIENTO");
                    Console.ReadLine();
                    break;
                default:
                    System.Console.WriteLine("Opcon Inválida, Intentelo de nuevo");

                    break;
                }
            }
        }

        private static void Menu()
        {
            throw new NotImplementedException();
        }
    }
}