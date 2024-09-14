namespace _10._Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------------------------ARRAYS BASICOS--------------------------------------------------------
            int[] Edades;   // Creacion de un array 
            double[] Altura = { 1.34, 1.86, 1.54 };  //Arreglo que se llena por defecto 
            Edades = new int[4];  // Creacion del tamaño del array
            Edades[0] = 1;
            Edades[1] = 2;
            Edades[2] = 3;
            Edades[3] = 4;
            Console.WriteLine(Edades[3]);
            Console.WriteLine(Altura[0]);

            //-----------------------------ARRAYS IMPLICTPS--------------------------------------------------------------------

            var Datos = new[] { "Juan", "Perez", "Pedro" };// No se le asigna un tipo de dato ni cantidad 

            
        }
    }

}
