namespace _12._Herencia__Sintaxis_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo();  // Instancias de la clase caballo 
            Humano Juan = new Humano();
            Gorila Copito = new Gorila();

            Copito.Trepar();
        }
    }

    class Mamiferos  // Creacion de la herecia                                                             
    {
        public void Respirar ()
        {
            Console.WriteLine("Soy capaz de respirar ");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar crias  hasta que se cuiden soolas");
        }
    }

    class Caballo: Mamiferos   // Asi se hacen las herencias en c#, los datos que tenemos en mamiferos, lo hereda Caballo 
    {
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos   // Hereda datos de la clase mamiferos 
    {
        public void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos  // Hereda datos de la clase mamiferos 
    {
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
