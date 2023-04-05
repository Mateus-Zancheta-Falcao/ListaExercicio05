using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class CaixaRetangular
    {
        public double comprimento { get; set; }
        public double largura { get; set; }
        public double altura { get; set; }
        public double Volume { get; set; }

        public double CalcularCaixa()
        {
            return Volume = comprimento * largura * altura;
        }
    }
}
