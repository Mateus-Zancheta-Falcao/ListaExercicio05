using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorFahrenheit conversor = new ConversorFahrenheit();

            Console.WriteLine("- Conversor de graus Fahrenheit para graus Celsius -\n");

            Console.WriteLine("Informe os graus Fahrenheit: ");
            conversor.Fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nO grau Celsius é: C° {conversor.CalculoFahrenheitParaCelsius()}");

            Console.ReadKey();
        }
    }
}
