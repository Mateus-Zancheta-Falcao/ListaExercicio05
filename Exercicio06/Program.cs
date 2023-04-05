using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorCelsius conversor = new ConversorCelsius();

            Console.WriteLine("- Conversor de graus Celsius para graus Fahrenheit -\n");

            Console.WriteLine("Informe os graus Celsius: ");
            conversor.Celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O grau Fahrenheit é: F° {conversor.CalculoCelsiusParaFahrenheit()}");

            Console.ReadKey();
        }
    }
}
