namespace _5._Condicional_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {

    //-----------------------CONDICIONAL SWITCH-----------------------------

            Console.WriteLine( "Elige un metodo de transporte  (Carro, Avion, tren ) ");  

            string Vehiculo = Console.ReadLine();  //Ingresa datos por teclado 

            switch (Vehiculo)  //condicional switch 
            {
                case "carro":   // Primer condicional si cumple con la caracterisitica 
                    Console.WriteLine("Velocidad media 100 km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media de 250 km/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media de 800 km/h");
                    break;

                default:  // Este elemento es si se desea hacer una default, no es necesario, y es similar a aun else 
                    Console.WriteLine("El dato que ingresaste no corresponde a ninguno");
                    break;
            
            }

        }
    }
}
