namespace _16._Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Empleado1 = new Empleado(12000, 2500);
            Empleado1.CambioSalario(  1000);

            Console.WriteLine(Empleado1);
        }
    }

    public struct Empleado   // creación de una estructura 
    {
        public double SalarioBase, Comision;

        public Empleado(double SalarioBase, double Comision)
        {
            this.SalarioBase = SalarioBase;
            this.Comision = Comision;
        }

        public override string ToString()
        {
            return string.Format("Salario y comisión del empleado ({0} , {1})", this.SalarioBase, this.Comision);
        }

        // Modificar el método para que reciba el empleado por referencia
        public void CambioSalario(double Incremento)
        {
            SalarioBase += Incremento;
            Comision += Incremento;
        }
    }
}
