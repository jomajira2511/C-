namespace _9._1_POO__Encapsulacion_y_Convensiones_
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            ConversionEuroToDolar Cambio;
            Cambio = new ConversionEuroToDolar();
            Console.WriteLine("Ingresa el precio del Euro actualmente : ");
            double NuevoValorEuro= Double.Parse(Console.ReadLine());
            Cambio.CambioValorEuro(NuevoValorEuro);
            Console.WriteLine("Ingrese la cantidad de euros que desea convertir");
            double Cantidad = Double.Parse(Console.ReadLine());
            Console.WriteLine( Cantidad +" Euros al cambio por dolares son : " + Cambio.Convertir(Cantidad));

        }
    }

    class ConversionEuroToDolar
    {
         double Euro = 1.1;

        public double Convertir(double Dolar)
        {
            return Dolar * Euro;

        }

        public void CambioValorEuro(double NuevoValor)   //Encapsulamos informacion con esto, evitamos que el cambio sea de tipo publico creando un metodo
        {
            if (NuevoValor < 0) Euro = 1.1; //En caso de que los datos ingresados por el usuario sean incorrectos, el programa tiene una forma de cuidarse de esto 

            else 
                Euro = NuevoValor;
        }

    }
}
