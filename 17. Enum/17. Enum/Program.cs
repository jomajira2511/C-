namespace _17._Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación del objeto empleado con bonus 'Extra' y salario base de 1900.50
            Empleado Juan = new Empleado(Bonus.Extra, 1900.50);

            // Corrección: se llama al método getSalario() con paréntesis
            Console.WriteLine("El salario del empleado es " + Juan.getSalario());
        }
    }

    class Empleado
    {
        public Empleado(Bonus BonusEmpleado, double Salario)
        {
            // Asignación del valor del enum 'Bonus' convertido a double
            bonus = (double)BonusEmpleado;
            this.Salario = Salario;
        }

        // Método para obtener el salario sumado con el bonus
        public double getSalario()
        {
            return Salario + bonus;
        }

        // Variables privadas para almacenar el salario y el bonus
        private double Salario, bonus;
    }

    // Definición del enum Bonus con diferentes valores predefinidos
    enum Bonus { Bajo = 500, Normal = 1000, Bueno = 1500, Extra = 3000 };
}
