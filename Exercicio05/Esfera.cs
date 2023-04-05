using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Esfera
    {
        public double pi { get; set; }
        public double raio { get; set; }
        public double altura { get; set; }
        public double volume { get; set; }


        public double CalculoEsfera()
        {
            pi = 3.14;

            volume = (4 * pi * Math.Pow(raio, 3)) / 3;
            volume = Math.Round(volume, 2);

            return volume;
        }
    }
}
