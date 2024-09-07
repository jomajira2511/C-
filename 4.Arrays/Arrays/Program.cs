namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // Arrays de tipo String --------------------------------------------
            // Declaración de un array de cadenas con un tamaño de 5
            string[] Cadenas = new string[5];

            //llenar el arreglo con datos predeterminamos 
            string[] Name = { "Jhon", "Juan", "Pedro", "Suarez", "Andres" };

            // Asignación de valores  a la posición  del array
            Cadenas[0] = "Jhon";
            Cadenas[1] = "Maria";
            Cadenas[2] = "Carlos";
            Cadenas[3] = "Sofia";
            Cadenas[4] = "Luis";

            // Impresión del valor almacenado en las posiciones del array 
            Console.WriteLine("Resultado Array Cadenas : {0} \n", Cadenas[0] + ", " + Cadenas[1] + ", " + Cadenas[2] + ", " + Cadenas[3] + ", " + Cadenas[4] + " \n");
            Console.WriteLine("Resultado Array Name : {0} \n", Name[0] + ", " + Name[1] + ", " + Name[2] + ", " + Name[3] + ", " + Name[4]);

            //----------------------------------------------------------------------

            //Arrays de tipo INT----------------------------------------------------

            int[] Enteros = new int[5];

            //Asignacion de valores en las posiciones del arreglo 
            int[] LLeno = {1,2,3,4,5,};

            //Asignacion de valores almacenando en las posiciones del array
            Enteros[0] = 6;
            Enteros[1] = 7;
            Enteros[2] = 8; 
            Enteros[3] = 9;
            Enteros[4] = 10;
            //Impresion de los datos del arreglo 

            Console.WriteLine("Resultado Array Name : {0} \n", LLeno[0] + ", " + LLeno[1] + ", " + LLeno[2] + ", " + LLeno[3] + ", " + LLeno[4]);
            Console.WriteLine("Resultado Array Int : {0} \n", Enteros[0] + ", " + Enteros[1] + ", " + Enteros[2] + ", " + Enteros[3] + ", " + Enteros[4] + " \n");

            //Creacion de un arreglo multidimensaional 

            double[,] Dimensional = new double[5,2] { {6,3.0 },{ 3, 2 }, { 10,15}, {3,2 }, {4,2.3 } };  // un array de 5 filos y 2 columnas

            Console.WriteLine("Imprimiendo los datos de el array en la pocision [0,0] del arreglo : {0}", Dimensional[0,0]);


            // Pausa el programa para evitar el cierre inmediato de la consola
            Console.ReadLine();
        }
    }
}
