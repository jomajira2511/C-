namespace Operadores
{
    class Operadores
    {
        static void Main(string[] args)
        {
            //Operadores en C#

            int A = 3;
            int B = 4;

            //Operadores Aritmeticos

            var Suma = A + B; //Suma 
            var Resta = A - B; // Resta
            var Multiplicacion = A * B; //Multiplicacion 
            var Division = A / B; //Division
            var Modulo = A % B; //Modulo 
            Console.WriteLine("Resultados de las operaciones:  Suma = {0}  Resta = {1} Multiplicacion = {2} Division  = {3} Modulo = {4} \n", Suma, Resta, Multiplicacion, Division, Modulo); //impresion de los datos 

            A = 3;
            B = 4;

            // Operadores de asignacion 
            var Valor1 = A += B;  //Permite hacer la suma y asignar los valores a la variable 
            var Valor2 = A -= B;
            var Valor3 = A *= B;
            Console.WriteLine("Resultado de Asignaciones :  Valor1 : {0}  Valor2 : {1} Valor3 : {2} \n ", Valor1, Valor2, Valor3);

            A = 3;
            B = 4;

            //Operadores Relacionales y de comprobacion

            var MenorQue = A < B;       //Menor que
            var MayorQue = A > B;       //Mayo que 
            var IgualQue = A == B;      //Igual que     
            var MayorOIgual = A >= B;   //Mayor o igual
            var MenorOIgual = A <= B;   //Menor o igual
            var Diferente  = A != B;

            Console.WriteLine("Resultado de las Asignaciones {0} {1} {2} {3} {4} {5}  ", MenorQue, MayorQue, IgualQue, MayorOIgual, MenorOIgual, Diferente);
            Console.ReadLine(); //Permite pausar el programa en la consola

        }

    }
}