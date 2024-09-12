namespace _3._Metodos
{
    internal class Program
    {
        // Variables de tipo globlal 
        static int Numero1 = 5;
        static int Numero2 = 7;


        static void Main(string[] args)
        {
            MensajeEnPantalla();
            SumaNumeros(5, 5);
            SumaNumeros1(10, 10);
            Suma();


            Console.WriteLine("Mensaje desde el main ");



            Console.ReadLine();
        }

        static void MensajeEnPantalla()  // Funciona que imprime un dato en pantalla
        {
            Console.WriteLine("Mensaje escrito desde el metodo MensajeEnPantalla ");

        }


        static void SumaNumeros(int num1, int num2) //Funcion que se le envian datos y les hace la suma  pero es tipo VOID
        {
            Console.WriteLine("La suma de los valores es : " + (num1 + num2));
        }

        static int SumaNumeros1(int num1, int num2) //Funcion que retorna un dato de algun tipo. 
        {
            return num1 + num2;
        }

         static void Suma()
        {
            Console.WriteLine("La suma de los datos es igual a : " + (Numero1 + Numero2));
        }


    }
}
