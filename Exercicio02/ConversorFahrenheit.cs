using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class ConversorFahrenheit
    {
        public double Fahrenheit { get; set; }
        public double Celsius { get; set; }

        public double CalculoFahrenheitParaCelsius()
        {
            Celsius = (Fahrenheit - 32) / 1.8;
            Celsius = Math.Round(Celsius, 2);

            return Celsius;
        }
    }
}
