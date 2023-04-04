using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class ConversorFahrenheit
    {
        public static double Fahrenheit { get; set; }
        public static double Celsius { get; set; }


        public static void CalculoFahrenheitParaCelsius()
        {
            Console.WriteLine("- Conversor de graus Fahrenheit para graus Celsius -\n");

            Console.WriteLine("Informe os graus Fahrenheit: ");
            Fahrenheit = Convert.ToDouble(Console.ReadLine());

            Celsius = (Fahrenheit - 32) / 1.8;

            Celsius = Math.Round(Celsius, 2);

            Console.WriteLine($"\nO grau Celsius é: C° {Celsius}");

            Console.ReadKey();
        }
    }
}
