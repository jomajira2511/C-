namespace _7._Bucle_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------DO WHILE-------------------

            int a = 10;

            do  //Ingresa directamente a la solucion, sin necesidad de que la condicion sea true 
            {
                Console.WriteLine("El numero es : " + a);
                a++;
            }
            while (a<20);  // Al finalizar la ejecucion, continua con su evaluacion, y en caso de ser true, vuelve y repite el bucle, hasta que la condicion sea false 
        }
    }
}
