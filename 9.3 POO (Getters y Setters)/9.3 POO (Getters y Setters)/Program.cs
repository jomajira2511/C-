namespace _9._3_POO__Getters_y_Setters_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carro1 = new Carro();  // Creamos una instancia de la clase carro, osea creamos una nueva "Rama"
                                         // Con el uso del contructor, le dimos un estado inicial al objeto carro que se creo anteriormente 

            Carro carro2 = new Carro();  // Se crea otro carro y tiene las mismas caracteristicas que tiene con el constructor

            Console.WriteLine(carro1.getInfoCarro());
            Console.WriteLine(carro2.getInfoCarro());


            Carro carro3 = new Carro(5000.3, 4300.2);// Creamos una instancia de coche, y le enviamos los datos al constructor para cargarlo con la informacion deseada 

            Console.WriteLine(carro3.getInfoCarro());

            //carro3.setExtras(true, "Cuero");
            Console.WriteLine(carro3.getInfoExtras());




        }
    }

    class Carro
    {
        public Carro()   //Constructor para darle un valor incial al proyecto, con las intancias que se declaren  
        {
            Ruedas = 4;
            Largo = 2300.5;
            Ancho = 0.800;
            Tapiceria = "Tela";
        }

        public Carro(double LargoCarro, double AnchoCarro)   // Segundo constructor que recibe los datos directamente por el usuario  en el metodo main 
        {
            Ruedas = 4;
            Largo = LargoCarro;
            Ancho = AnchoCarro;
            Tapiceria = "Tela";
        }

        public string getInfoCarro()  // Con este metodo si tenemos una clase privada, podemos tener acceso a toda la informacion que deseemos
        {
            return $"\nInformacion del carro \nRuedas : {Ruedas}\nLargo : {Largo}\nAncho : {Ancho}\nTapiceria : {Tapiceria}";
        }

        public void setExtras(bool ParamClimatizador, string PAramTapiceria)   //Permite darle valor a el objeto mediante datos ingresador por el usuario 
        {
            Climatizador = ParamClimatizador;
            Tapiceria = PAramTapiceria;

        }
        
        public string getInfoExtras()
        {
            return $"\nExtras del carro \nTapiceroa : {Tapiceria} \nClimatizador: {Climatizador}";
        }

        private int Ruedas;     //Caracteristicas de la clase o ATRIBUTOS O PROPIEDADES
        private double Largo;   //Caracteristicas de la clase o ATRIBUTOS O PROPIEDADES
        private double Ancho;   //Caracteristicas de la clase o ATRIBUTOS O PROPIEDADES
        private bool Climatizador;
        private string Tapiceria;



    }
}
