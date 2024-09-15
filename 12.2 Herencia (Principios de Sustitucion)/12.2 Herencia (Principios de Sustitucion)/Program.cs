namespace _12._2_Herencia__Principios_de_Sustitucion_
{
                                                                                           //         Mamiferos 
                                                                                             //              |
                                                                                             //       |-------|-----------|
                                                                                             //    Humanos   Caballo    Gorila
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");  // Instancias de la clase caballo 
            Humano Juan = new Humano("Andres");
            Gorila Copito = new Gorila("Copito");
            //---------------------Principio de sustitucion-------------

            Mamiferos Animal = new Caballo("Bucefalo");   // Tomamos la Super Clase Mamiferos y la instanciamos y creamos una nueva subclase llamada Animal y le damos el nombre de Bucefalo 
            Animal.getNombre();
            Mamiferos Persona = new Humano("Pedro Suarez");

            Mamiferos[] AlmacenAnimales = new Mamiferos[3]; // Creamos una sustitucion de tipo array y almacenamos la informacion 
            AlmacenAnimales[0] =Babieca;
            AlmacenAnimales[1] =Juan;     //llenamos la matriz anteriormente creada 
            AlmacenAnimales[2] = Copito;

            for (int i = 0; i < AlmacenAnimales.Length; i++)
            {
                AlmacenAnimales[i].getNombre();   //llama la funcion getnombre e imprime los datos con los que se llenaron

            }
            
        }
    }

    class Mamiferos  // Creacion de la herecia o super clase                                                      
        {
            public Mamiferos(string Nombre)   //Constructor para la clase mamiferos 
            {
                NombreSerVivo = Nombre;

            }

            public void Respirar()
            {
                Console.WriteLine("Soy capaz de respirar ");
            }

            public void CuidarCrias()
            {
                Console.WriteLine("Soy capaz de cuidar crias  hasta que se cuiden soolas");
            }

            public void getNombre()   // Permite buscar el nombre de la clase 
            {
                Console.WriteLine($"El nombre del ser vivo es : {NombreSerVivo}");
            }

            private string NombreSerVivo;  //Campo de clase encapsulado para todos los seres vivos que hereden 
        }

    class Caballo : Mamiferos   // Asi se hacen las herencias en c#, los datos que tenemos en mamiferos, lo hereda Caballo 
        {
            public Caballo(string NombreCaballo) : base(NombreCaballo) //Creacion de un contenedor para caballo que hereda el contructor de mamiferos 
            {

            }

            public void Galopar()
            {
                Console.WriteLine("Soy capaz de galopar");
            }
        }

    class Humano : Mamiferos   // Hereda datos de la clase mamiferos 
        {

            public Humano(string NombreHumano) : base(NombreHumano)
            {

            }
            public void Pensar()
            {
                Console.WriteLine("Soy capaz de pensar");
            }
        }

    class Gorila : Mamiferos  // Hereda datos de la clase mamiferos 
        {
            public Gorila(string NombreGorila) : base(NombreGorila)
            {

            }
            public void Trepar()
            {
                Console.WriteLine("Soy capaz de trepar");
            }
        }

}
