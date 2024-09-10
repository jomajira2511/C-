namespace SintaxisBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------Creacion de Variables en C# ----------------------------
            //Declaramos la variable y le asignamos el dato 
            int edad = 18;   //Tipo entero 
            float Pi = 3.1416F;  // tipo float o decimal 
            char Letra = 'a';  //Tipo caracter
            string Nombre = "Pepitop Perez";  // Tipo String 
            bool Falso = false;  //Tipo Booleano
            Console.WriteLine("Estos son los tipos de datos en C#");
            Console.WriteLine("Entero : " +  edad  + "\nDecimal : " + Pi  + "\nCaracter : " + Letra + "\nCadena : " + Nombre + "\nBooleano : " + Falso);


            //------------------------------------Operadores Aritmeticos-----------------------------------------
            var A = 5;
            var B = 5;
            var Suma = A + B;
            var Resta = A - B;
            var Multiplicacion = A * B;
            var Division = A / B;
            var Modulo = A % B;
            Console.WriteLine
                (
                    "\nEstos son los tipos de operaciones aritmeticas  en C# "
                    + "\nSuma  :  " + A + " + " + B + " : " + Suma + "\nResta  :  " + A + " - " + B + " : " + Resta + "\nMultiplicacion  :  " + A + " * " + B + " : " + Multiplicacion
                    + "\nDivision  :  " + A + " / " + B + " : " + Division + "\nModulo  :  " + A + " % " + B + " : " + Modulo
                );
            

            //---------------------------Conversion Explicita------------------------------------------------
            double Temperatura = 30.3;
            int TemperaturaNueva;
            TemperaturaNueva = (int)(Temperatura);
            Console.WriteLine
                (
                    "\nConvertimos el dato de tipo flotante a entero \nTemperatura en flotante  :" + Temperatura +"\nDespues de la conversion \n" +
                    "Temperatura en entero : " + TemperaturaNueva
                );


            //------------------------------Conversion de texto a numero-------------------------------------------
            Console.Write("\nIngresa dos numeros para sumarlos \nIntroduce un numero : ");
            int Num1 = int.Parse(Console.ReadLine()); //Con este metodo podemos ingresar datos por teclado
            Console.Write("Ingresa el segundo numero : ");
            int Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma es = {Num1} + {Num2} : {Num1 + Num2}" );

            //------------------------------------------------Constantes-----------------------------------

            const double PI = 3.1416;   // Esta es una constane universal, no permite que se modifique y sera igual en toda la ejecucion del programa
            Console.WriteLine($"\nEl valor de la constanteque hemos declarado PI {PI}");






        }
    }
}
