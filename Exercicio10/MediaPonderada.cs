using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class MediaPonderada
    {
        public double N1 { get; set; }
        public double N2 { get; set; }
        public double mediaPonderada { get; set; }

        public double CalculoMediaPonderada()
        {
            mediaPonderada = (N1 * 1) + (N2 * 1) / 2;

            return mediaPonderada;
        }
    }
}
