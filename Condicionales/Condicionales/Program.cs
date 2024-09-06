namespace Condicionales
{
    class Condicionales
    {
        static void Main(string[] args)
        {
            // Condicionales en C#

            var A = 113;
            var B = 4;
            var C = 22;
            var D = 6;

            // && And
            // || OR

            // Condicional IF
            if (A > B)  // Entra el resultado, hace la condicion y en caso de ser correcta, entra al ciclo y realiza la operacion asignada
            {
                Console.WriteLine("Es Correcto \n");
            }
            else  // En caso de que no se cumpla con la primera condicion del IF, entrara a esta y hara lo que se asigne
            {
                Console.WriteLine("No fue correcta la condición inicial A > B");
            }

            Console.WriteLine("Fin de la primer condicion ------------------- \n \n \n ");

            //Condicional IF Anidada

            if (A > B)  // Entra el resultado, hace la condicion y en caso de ser correcta, entra al ciclo y realiza la operacion asignada
            {
                if (A < C)
                {
                    Console.WriteLine("Son Correctas ambas apreciasiones");
                }
                else
                {
                    Console.WriteLine("La segunda condicion no fue aceptada ");
                }
            }
            else  // En caso de que no se cumpla con la primera condicion del IF, entrara a esta y hara lo que se asigne
            {
                Console.WriteLine("No fue correcta la condición inicial A > B");
            }
        }
    }
}
