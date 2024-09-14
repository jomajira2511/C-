namespace _9._5_POO__LLamadas_y_Clase_Math_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealizarTarea();
        }

        static void RealizarTarea()
        {
            Punto Origen = new Punto(); //LLamamos  el constructor de la clase Punto   y NO le enviamos parametros, son los que tenemos por defecto 
            Punto Destino = new Punto(150, 90);  //Llamos el nuevo objeto creado, y le enviamos informacion al objeto 

            double distancia= Origen.Distancia(Destino);

            Console.WriteLine( $"La Distancia entre los puntos es: {distancia}");

        }
    }
}
