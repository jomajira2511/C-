namespace _9._4_POO__Visual_Studio_y_POO_
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
            Punto Destino = new Punto(120, 123);  //Llamos el nuevo objeto creado, y le enviamos informacion al objeto 
             
        }
    }
}
