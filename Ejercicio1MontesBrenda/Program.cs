using System;

namespace Ejercicio1MontesBrenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar;
            double euro;
            double pesos;
            double division;

            Console.Write("Ingrese la cantidad de pesos: ");
            pesos = double.Parse(Console.ReadLine());

            dolar = pesos / 230;
            euro = dolar / 1.17;

            Console.WriteLine($"Los dolares que puede comprar son: {dolar} ");
            Console.WriteLine($"Los euros que puede comprar son: {euro}");

            Console.ReadLine();
        }
    }
}
