using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4_POO__Visual_Studio_y_POO_
{
    class Punto
    {
        public Punto(int x, int y)   //Genera un objeto de la clase Punto 
        {
            Console.WriteLine( $"Coordenada x {x} , Coordenata y {y}");
        }

        public Punto() // Contructor que creamos para el objeto Punto 
        {
            Console.WriteLine("Estos son los datos que tiene el constructor por defecto ");
        }
       
    }
}
