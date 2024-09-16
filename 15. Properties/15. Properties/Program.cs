using System.Data;

namespace _15._Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado Juan = new Empleado("Juan");  //Creamos la instancia 
            Juan.SALARIO = 12000;
            Console.WriteLine($"El salario del empleado es {Juan.SALARIO}");
          

        }




        class Empleado
        {
            public Empleado(string Nombre)   // Constructor que permite tener un nombre 
            {
                this.Nombre = Nombre;
            }


            public double getSalario()  // Este metodo devuelve el salario del empleado 
            {
                return Salario;
            }
            private double EvaluaSalario(double Salario)   //Metodo que evalua salario 
            {
                if (Salario < 0) return 0;
                else return Salario;
            }

            // Creacion de la propiedad 
            //public double SALARIO
            //{
            //    get { return this.Salario; }
            //    set { this.Salario = EvaluaSalario(value); }
            //}

            // Forma mas sencilla para los propertis 

            public double SALARIO   // Forma mas sencilla de hacer un property 
            {
                get => this.Salario;
                set => this.Salario = EvaluaSalario(value);
            }
            // --------------Campos encapsulados---------------------------
            private double Salario;
            private string Nombre;
        }
    }
}
