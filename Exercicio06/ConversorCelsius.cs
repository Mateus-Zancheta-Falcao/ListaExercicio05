using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class ConversorCelsius
    {
        public static double Fahrenheit { get; set; }
        public static double Celsius { get; set; }


        public static void CalculoCelsiusParaFahrenheit()
        {
            Console.WriteLine("- Conversor de graus Celsius para graus Fahrenheit -\n");

            Console.WriteLine("Informe os graus Celsius: ");
            double Celsius = Convert.ToDouble(Console.ReadLine());

            double Fahrenheit = (Celsius * 1.8) + 32;

            Fahrenheit = Math.Round(Fahrenheit, 2);

            Console.WriteLine($"O grau Fahrenheit é: F° {Fahrenheit}");

            Console.ReadKey();
        }
    }
}
