namespace _11._Bucle_For_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------ARRAYS BASICOS--------------------------------------------------------
            int[] Edades;   // Creacion de un array 
            double[] Altura = { 1.34, 1.86, 1.54 };  //Arreglo que se llena por defecto 
            Edades = new int[5];  // Creacion del tamaño del array
            Edades[0] = 1;
            Edades[1] = 2;
            Edades[2] = 3;
            Edades[3] = 4;
            Edades[4] = 5;
            Console.WriteLine(Edades[3]);
            Console.WriteLine(Altura[0]);

            //-----------------------------ARRAYS IMPLICTPS--------------------------------------------------------------------

            var Datos = new[] { "Juan", "Perez", "Pedro","Suarez", "Andres" };// No se le asigna un tipo de dato ni cantidad 

            // --------------------------------USO DEL BUCLE FOR----------------------------------------------

            for (int i = 0; i < Datos.Length; i++)  // Permite hacer un ciclo usando el objeto .Length que permite trabajar con el tamaño del arreglo 
            {

                Console.WriteLine($"Nombre : {Datos[i]} Edad: {Edades[i]} \n"); // imprime los datos que estan en la posicion i 


            }


            //----------------------------USO DEL BLOQUE FOREACH----------------------------------------------
           

        }
    }
}
