using System;
using System.Globalization;

namespace CalculoDeRaio
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, x, raio;
            n = 3.14159;

            Console.WriteLine("Digite o raio:");
            x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            raio = n * (x * x);
            Console.WriteLine("O resultado é : " + raio.ToString("F4", CultureInfo.InvariantCulture));


        }

    }
}
