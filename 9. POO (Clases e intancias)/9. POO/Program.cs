namespace _9._POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo MiCirculo; // Creacion de objeto de tipo circulo o variable objeto de tipo circulo 
            MiCirculo = new Circulo(); //Iniciacion de variable/objeto de tipo circulo  o instancias una clase 
            Console.WriteLine("Ingresa el Radio del circulo  para calcular el area ");
            int radio  = Int32.Parse(Console.ReadLine());  
            Console.WriteLine(MiCirculo.CalculoArea(radio));  //Envia el dato para ser usado en la clase y a su vez lo imprime 
        }
    }

     class Circulo //Creacion de una clase  caracteristicas 
    {
        const double Pi = 3.1416;  //Propiedad o atributo de la clase circulo o campo de clase 

        public double CalculoArea(int Radio)  //Metodo de clase, osea qeu pueden hacer 
        {
            return (Pi * Radio*Radio);
        }
    }














}
