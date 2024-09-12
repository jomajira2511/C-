namespace _6._Bucle_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------BUCLE WHILE---------------------------------------------
            //Cantidad de veces que se desea ver un numero en pantalla 
            Console.WriteLine("Introduce la cantidad de numeros que deseas ver ");
            int Impresion = 0;
            int Numeros = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Haz elegido ver : "+ Numeros +"Numeros ");

           while (Impresion <= Numeros)  //Condicional while 
            {
                Console.WriteLine(Impresion);
                Impresion++;
            }
            Console.WriteLine("Hemos termiando la ejecucion ");
  
        }
    }
}

