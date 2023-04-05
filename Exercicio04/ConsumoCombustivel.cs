using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class ConsumoCombustivel
    {
        public double QuilometragemInicial { get; set; }
        public double QuilometragemFinal { get; set; }
        public double QuantidadeComb { get; set; }
        public double Consumo { get; set; }

        public double CalculoCombustivel()
        {
            Consumo = (QuilometragemInicial + QuilometragemFinal) / QuantidadeComb;
            Consumo = Math.Round(Consumo, 2);

            return Consumo;
        }
    }
}
