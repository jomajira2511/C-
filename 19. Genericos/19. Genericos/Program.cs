namespace _19._Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos Archivos = new AlmacenObjetos(4);

            Archivos.Agregar("Pedro");
            Archivos.Agregar("Andres");
            Archivos.Agregar("Pablo");
            Archivos.Agregar("Juan");

            string NombrePersona = (String)Archivos.getElemento(2);
            Console.WriteLine(NombrePersona);
        }
    }

    class AlmacenObjetos
    {
        public AlmacenObjetos(int Z)   // Construnctor que almacena datos 
        {

            DatosElemento = new Object[Z];

        }
        public void Agregar (Object obj)  // con este metodo agregamos el object 
        {
            DatosElemento[i] = obj;
            i++;
        }

        public Object getElemento(int i)
        {
            return (DatosElemento[i]);
        }

        private Object[] DatosElemento;
        private int i = 0;
    }

}
