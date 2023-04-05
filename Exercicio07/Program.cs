using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            Console.WriteLine("- Calculadora de salário -\n");

            Console.WriteLine("Informe o salário base: ");
            salario.SalarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas: ");
            salario.TotalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de comissão: ");
            salario.percentual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O salário total do vendedor será de: {salario.CalculoSalario()}");
            Console.ReadKey();
        }
    }
}
