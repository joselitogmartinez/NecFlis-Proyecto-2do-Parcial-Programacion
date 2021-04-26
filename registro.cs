using System;

namespace Necflis
{
    class registro{
        public string nombre_usuario;

        public string peliculas_usuario;

        public int cantidad;

        public string[] lista;
        public registro(string nombre_usuario, string peliculas_usuario, int cantidad){
            this.nombre_usuario = nombre_usuario;
            this.peliculas_usuario =  peliculas_usuario;       
            this.cantidad = cantidad;     
        }

        public registro(string nombre_usuario,string[] lista){
            this.nombre_usuario = nombre_usuario;
            this.lista = lista;
        }
        
    }
}