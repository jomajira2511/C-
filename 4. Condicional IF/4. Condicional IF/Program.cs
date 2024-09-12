using System.ComponentModel.DataAnnotations;

namespace _4._Condicional_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingresa tu edad ");
            edad = Int32.Parse(Console.ReadLine());    //Ingresamos los datos por teclado 


            if (edad > 18 )   //Creamos la respectiva condicion IF
                {
                Console.WriteLine("Ustes es mayor de edad ");
                }
            else  //En caso que la condicion sea falsa 
            {
                Console.WriteLine("Usted es menor de edad");
            }

            //------------------------------------else if-------------------------------------------

            //Creamos la respectiva condicion else if 
            if (edad < 18) Console.WriteLine("Eres un niño");

            else if (edad < 30) Console.WriteLine("Eres un joven ");

            else if (edad < 60) Console.WriteLine("Eres viejo");

            else Console.WriteLine("Deberias cuidarte, estas muy viejo");



            Console.ReadLine();
            
        }
    }
}
