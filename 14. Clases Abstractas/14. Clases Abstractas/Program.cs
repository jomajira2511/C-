namespace _14._Clases_Abstractas                                       // tenemos una herencia de la siguiente forma
{                                                                                        //         Mamiferos 
                                                                                         //              |
                                                                                         //       |-------|-----------|
                                                                                         //    Humanos   Caballo    Gorila
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");  // Instancias de la clase caballo 
            IMamiferosTerrestres IBabieca = Babieca;  // Para poder acceder a una clase privada usamos esto 
            ISaltoConPAtas IMiBabieca = Babieca;
            Humano Juan = new Humano("Andres");
            Gorila Copito = new Gorila("Copito");
            Mamiferos[] AlmacenAnimales = new Mamiferos[3]; // Creamos una sustitucion de tipo array y almacenamos la informacion 
            AlmacenAnimales[0] = Babieca;
            AlmacenAnimales[1] = Juan;     //llenamos la matriz anteriormente creada 
            AlmacenAnimales[2] = Copito;

            for (int i = 0; i < AlmacenAnimales.Length; i++)
            {
                AlmacenAnimales[i].Pensar();   //llama la funcion Pensar  e imprime los datos con los que se llenaron

            }

            Ballena MiWally = new Ballena("Wally");

            MiWally.Nadar();

            Console.WriteLine($"Numero de patas del caballo es {IBabieca.NumeroPatas()}");
            Console.WriteLine($"Patas utilizadas en el salo es {IMiBabieca.NumeroPatas()}");  // Hacemos el llamado para la clase y nos devuevla las patas con las que salta 

            Lagartija Juancho = new Lagartija("Pepito");
            Juancho.Respirar();
            Juan.Respirar();
            Juancho.getNombre();
            Juan.getNombre();
        }
    }

    interface IMamiferosTerrestres   // Interfas, como convencion se debe de escribir I antes de el nombre que se desee asignar 
    {
        int NumeroPatas();
    }
    interface IAnimalesYDeportes   // Interfaz especifica solo para mamiferos especificios 
    {
        string TipoDeporte();
        Boolean Olimpico();
    }
    interface ISaltoConPAtas
    {
        int NumeroPatas();
    }

    abstract class Animales   // Creacion de una clase abstracta
    {
        public void Respirar ()   //Creacion de la clase respirar 
        {
            Console.WriteLine("Soy capaz de respirar ");
        }
        public abstract void getNombre();


    }

    class Lagartija : Animales
    {
        public Lagartija(string Nombre)
        {
            NombreReptil = Nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine($"El Nombre del reptil es : {NombreReptil} ");
        }
        private string NombreReptil;
    }


    class Mamiferos: Animales  // Creacion de la herecia o super clase                                                      
    {


        public Mamiferos(string Nombre)   //Constructor para la clase mamiferos 
        {
            NombreSerVivo = Nombre;

        }

        

        public void CuidarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar crias  hasta que se cuiden soolas");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo ");
        }

        public override void getNombre()   // Permite buscar el nombre de la clase 
        {
            Console.WriteLine($"El nombre del Mamifero es  : {NombreSerVivo}");
        }

        private string NombreSerVivo;  //Campo de clase encapsulado para todos los seres vivos que hereden 
    }

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPAtas  // Asi se hacen las herencias en c#, los datos que tenemos en mamiferos, lo hereda Caballo 
    {
        public Caballo(string NombreCaballo) : base(NombreCaballo) //Creacion de un contenedor para caballo que hereda el contructor de mamiferos 
        {

        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        int IMamiferosTerrestres.NumeroPatas() // Se llama la interfaz, y se especifica la cantidad de patas que tiene el caballo 
        {// Con este nombre nos aseguramos que estamos en la interfaz de mamiferos, pero especificamos que va al contructor de numero de patas 
            return 4;
        }

        public string TipoDeporte()   // Asociamos la interfaz y le damos propiedades a la clase de caballo 
        {
            return "Carreras";
        }

        public Boolean Olimpico()   // Segundo item de la interfaz desarrollada 
        {
            return true;
        }
        int ISaltoConPAtas.NumeroPatas() // como teniamos otro dato con la misma variable "NumeroDePatas", con esto podemos hacer que el IDE sepa cuando es el metodo 
        {
            return 2;
        }

    }

    class Humano : Mamiferos    // Hereda datos de la clase mamiferos 
    {

        public Humano(string NombreHumano) : base(NombreHumano)
        {

        }
        public override void Pensar()  //override, permite manejar un estado solo para el 
        {
            Console.WriteLine("Soy capaz de pensar");
        }

    }

    class Gorila : Mamiferos, IMamiferosTerrestres // Hereda datos de la clase mamiferos 
    {
        public Gorila(string NombreGorila) : base(NombreGorila)
        {

        }
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento basico primitivo");
        }
        public int NumeroPatas()
        {
            return 2;
        }
    }

    class Ballena : Mamiferos
    {
        public Ballena(string NombreBallena) : base(NombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar ");
        }
    }

}




