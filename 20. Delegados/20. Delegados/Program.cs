namespace _20._Delegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creacion del delegado apuntandoa  Mensaje Bienvenida 
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            ElDelegado();

            ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            ElDelegado();
        }

        // Definicion del delegado 
        delegate void ObjetoDelegado();
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Hola Acabo de llegar");
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida()
        {
            Console.WriteLine("Hola  ya me marcho");
        }
    }
}
