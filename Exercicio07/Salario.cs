using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Salario
    {

        public double SalarioBase { get; set; }
        public double TotalVendas { get; set; }
        public double percentual { get; set; }
        public double comissao { get; set; }
        public double SalarioFinal { get; set; }

        public double CalculoSalario()
        {
            comissao = (TotalVendas * percentual) / 100;
            SalarioFinal = SalarioBase + comissao;

            return SalarioFinal;
        }
    }
}
