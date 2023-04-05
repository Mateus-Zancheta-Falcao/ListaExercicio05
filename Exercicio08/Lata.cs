using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Lata
    {
        public double pi { get; set; }
        public double raio { get; set; }
        public double altura { get; set; }
        public double volume { get; set; }

        public double CalculoLata()
        {
            pi = 3.14;
            volume = pi * (raio * raio) * altura;

            return volume;
        }
    }
}
