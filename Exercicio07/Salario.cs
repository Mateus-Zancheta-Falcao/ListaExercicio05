using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Salario
    {

        public static double SalarioBase { get; set; }
        public static double TotalVendas { get; set; }
        public static double percentual { get; set; }
        public static double comissao { get; set; }
        public static double SalarioFinal { get; set; }

        public static void CalculoSalario()
        {
            Console.WriteLine("- Calculadora de salário -\n");

            Console.WriteLine("Informe o salário base: ");
            SalarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas: ");
            TotalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de comissão: ");
            percentual = Convert.ToDouble(Console.ReadLine());

            comissao = (TotalVendas * percentual) / 100;

            SalarioFinal = SalarioBase + comissao;

            Console.WriteLine($"O salário total do vendedor será de: {SalarioFinal}");
        }
    }
}
