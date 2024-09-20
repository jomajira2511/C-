namespace _19._Genericos
{
    // Clase principal donde se ejecuta el programa
    internal class Program
    {
        // Método principal donde comienza la ejecución del programa
        static void Main(string[] args)
        {
            // Se crea un almacén genérico para objetos de tipo Empleado, con capacidad para 4 elementos
            AlmacenObjetos<Empleado> Archivos = new AlmacenObjetos<Empleado>(4);

            // Se agregan 4 objetos de tipo Empleado al almacén con diferentes salarios
            Archivos.Agregar(new Empleado(1500));  // Empleado con salario 1500
            Archivos.Agregar(new Empleado(2500));  // Empleado con salario 2500
            Archivos.Agregar(new Empleado(3500));  // Empleado con salario 3500
            Archivos.Agregar(new Empleado(4500));  // Empleado con salario 4500

            // Se obtiene el tercer empleado del almacén (índice 2) y se muestra su salario
            Empleado SalarioEmpleado = Archivos.getElemento(1);  // Obtiene el empleado en el índice 2
            Console.WriteLine(SalarioEmpleado.getSalario());     // Imprime el salario del empleado
        }
    }

    // Clase genérica que permite almacenar objetos de cualquier tipo
    class AlmacenObjetos<T>
    {
        // Constructor que inicializa un arreglo para almacenar elementos del tipo especificado (T)
        public AlmacenObjetos(int Z)
        {
            // Se crea un arreglo de tipo T con tamaño Z
            DatosElemento = new T[Z];
        }

        // Método que permite agregar un objeto de tipo T al almacén
        public void Agregar(T obj)
        {
            // Se almacena el objeto en la posición actual del índice
            DatosElemento[i] = obj;
            // Se incrementa el índice para la próxima posición en el arreglo
            i++;
        }

        // Método que permite obtener un objeto del almacén en un índice específico
        public T getElemento(int i)
        {
            // Retorna el objeto almacenado en la posición i
            return DatosElemento[i];
        }

        // Arreglo privado que almacena los elementos de tipo T
        private T[] DatosElemento;
        // Variable privada que lleva el control de la posición en el arreglo
        private int i = 0;
    }

    // Clase que representa a un empleado con un salario
    class Empleado
    {
        // Constructor que inicializa el salario del empleado
        public Empleado(double Salario)
        {
            // Asigna el valor del salario proporcionado al campo privado
            this.Salario = Salario;
        }

        // Método que devuelve el salario del empleado
        public double getSalario()
        {
            // Retorna el valor del salario
            return Salario;
        }

        // Campo privado que almacena el salario del empleado
        private double Salario;
    }
}
