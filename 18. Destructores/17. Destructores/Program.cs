namespace _17._Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea una instancia de la clase ManejoArchivos, lo que ejecuta su constructor
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            
            // Llama al método Mensaje de la clase ManejoArchivos para imprimir el número de líneas leídas
            manejoArchivos.Mensaje();
        }
    }

    class ManejoArchivos
    {
        // StreamReader para manejar la lectura del archivo de texto
        private StreamReader Archivo = null;

        // Contador para llevar el registro del número de líneas leídas
        private int Contador = 0;

        // Variable para almacenar temporalmente cada línea leída del archivo
        private string Linea;

        // Constructor de la clase ManejoArchivos
        public ManejoArchivos()
        {
            // Abre el archivo de texto ubicado en la ruta especificada
            Archivo = new StreamReader(@"C:\texto.txt");

            // Lee cada línea del archivo hasta llegar al final (cuando ReadLine() devuelve null)
            while ((Linea = Archivo.ReadLine()) != null)
            {
                // Imprime la línea actual en la consola
                Console.WriteLine(Linea);

                // Incrementa el contador de líneas
                Contador++;
            }
        }

        // Método que imprime el número total de líneas leídas del archivo
        public void Mensaje()
        {
            // Imprime el número total de líneas leídas
            Console.WriteLine($"Hay {Contador} líneas");
        }

        // Destructor de la clase, se invoca cuando el objeto es destruido por el recolector de basura
        ~ManejoArchivos()
        {
            // Cierra el archivo si aún está abierto para liberar los recursos
            Archivo.Close();
        }
    }
}
