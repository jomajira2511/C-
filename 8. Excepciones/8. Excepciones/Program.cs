namespace _8._Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                // ---------------------------EXCEPCIONES usando TRY CATCH----------------------------------------
                Random Numero = new Random();   // Generacion de un numero aleatorio

                int Aleatorio = Numero.Next(0, 100);  // Generacion de un numero aleatorio, usando el parametro para definir su rango [0-100]
                int MiNumero;
                int Intentos = 0;
                Console.WriteLine("Vamos a jugar a adivinar el numero \n Ingresa un numero del 1 al 100 :  ");
                do
                {
                    Intentos++;
                    // Inicio de la excepcion 
                    try  //Excepcicion para encontrar el problema que se presente 
                    {
                        MiNumero = int.Parse(Console.ReadLine());
                    }
                    catch(FormatException ex) //La consecuencia al ingresar un dato que no se ha pedido 
                    {
                        Console.WriteLine("El dato que haz ingresado no es un numero  ");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Ingresa de nuevo el valor\n");
                        MiNumero = 0;  // El valor ingresado lo tomara como  0 
                    }
                    catch(OverflowException ex)  // Si el usuario ingresa un dato que es demasi
                    {
                        Console.WriteLine("El numero  que haz ingresado es de demasiado alto  ");
                        Console.WriteLine(ex.Message);  
                        Console.WriteLine("Ingresa de nuevo el valor\n");
                        MiNumero = 0;  // El valor ingresado lo tomara como  0 
                    }

                    if (MiNumero > Aleatorio) Console.WriteLine("El numero es menor ");
                    if (MiNumero < Aleatorio) Console.WriteLine("El numero es mayor");

                } while (Aleatorio != MiNumero);
                Console.WriteLine($"Es correcto, haz adivinado despues de {Intentos} Intentos");


        // ------------------------------------------------FIN EXCEPTION USANDO TRY CATCH------------------------------
            */
        //---------------------------------------------------USO DEL THROW CON LA FUNCUION NombreDelMes---------------------------
            Console.WriteLine("Introduce un numero de mes");
            int NumeroMes = int.Parse(Console.ReadLine());
            try  // Esta excepcion atrapa enc aso de que el dato enviado a la funcion devuelva la excepcion  y permita evitar el colapso del programa 
            {
                Console.WriteLine(NombreDelMes(NumeroMes));
            }
            catch(Exception ex) 
            {
                Console.WriteLine("El error que tuviste es de tipo " + ex.Message);
                
            }
        //----------------------------------------------------Fin del uso del throw-----------------------------------------------------
            

        }
        public static string NombreDelMes(int Mes)
        {
            switch (Mes)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febrero";

                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "Julio";

                case 8:
                    return "Agosto";

                case 9:
                    return "Septiembre";

                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";

                default:

                    throw new ArgumentOutOfRangeException(); //throw que permite crear una propia excepcion, en este caso se da cuento el usuario ingresa un valor que no esta especificado en el swith 

             }
           

        }
    }
}
