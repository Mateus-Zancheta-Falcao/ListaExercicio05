using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class ConversorCelsius
    {
        public double Fahrenheit { get; set; }
        public double Celsius { get; set; }


        public double CalculoCelsiusParaFahrenheit()
        {
            Fahrenheit = (Celsius * 1.8) + 32;
            Fahrenheit = Math.Round(Fahrenheit, 2);

            return Fahrenheit;
        }
    }
}
