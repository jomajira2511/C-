using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5_POO__LLamadas_y_Clase_Math_
{
    class Punto
    {
        public Punto(int x, int y)   //Para todos los objetos de la clase Punto que se le ingresan datos por parametro 
        {
            this.x = x;   //Permite usar las variables de forma "repetida"
            this.y = y; 
        }

        public Punto() // Contructor que creamos para el objeto Punto 
        {
            this.x = 0;
            this.y = 0;
        }

        public double Distancia(Punto OtroPunto)
        { 
            int xDif = this.x - OtroPunto.x;

            int yDif = this.y - OtroPunto.y;
            
            double DistanciaEntrePuntos = Math.Sqrt(Math.Pow(xDif, 2)+ Math.Pow(yDif, 2)); 

            return DistanciaEntrePuntos;
        }

        private int x, y;





    }
}
