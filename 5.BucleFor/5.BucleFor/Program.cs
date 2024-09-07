namespace For
{
    class BucleFor
    {
        static void Main(string[] args)
        {
            string[] name = { "Alex", "Juan", "Pedro" };//lleno un array con datos que permiten ser usados posteriormente 
            int[] age = { 23, 32, 43 };


            for (int i = 0; i < name.Length; i++)  //ciclo for que permite hacer una ejecucion de un programa durante el cumplimiento de la condicion 
            {
                Console.WriteLine("Hola, yo soy : {0}", name[i] + " Edad : "+ age[i]);
            }

            foreach (var item in age) //Permite trabajar directamente con  los arreglos 
            {
                Console.WriteLine("Las edades son : {0}",item);//Trabaja con el tamaño de los arreglos 
            }
            // Pausa el programa para evitar el cierre inmediato de la consola
            Console.ReadLine();
        }
    }
}
