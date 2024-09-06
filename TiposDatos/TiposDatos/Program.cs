namespace Tipos_De_Datos
{
    class TiposDatos
    {
        static void Main(string[] args)
        {
            //Tipos de datos en C#

            int Year = 10;   //Datos de tipo entero 
            double Decimales = 2.5; // Datos de tipo Double
            string Cadena = "Hola Mundo"; //Datos de tipo String
            decimal Decimal = 2.01M;  //Datos de tipo Decimal
            float Flotante = 8.98F;  //Datos de tipo Flotante 
            bool Valor = false;  //Dato de tipo Booleano 
            char Caracter = 'A';  //Dato de topo Caracter 



            Console.WriteLine("Hello World  {0} {1} {2} {3} {4} {5} {6} ", Year, Decimales, Cadena, Decimal, Flotante, Valor, Caracter); //impresion de los datos 
            Console.ReadLine(); //Permite pausar el programa en la consola 


        }



    }
}