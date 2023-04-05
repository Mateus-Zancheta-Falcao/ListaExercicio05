using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoCombustivel combustivel = new ConsumoCombustivel();

            Console.WriteLine("- Calculadora para o consumo de combustível por Km -\n");

            Console.Write("Informe a quilometragem inicial: ");
            combustivel.QuilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quilometragem final: ");
            combustivel.QuilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quantidade de combustível: ");
            combustivel.QuantidadeComb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nO consumo de combustível foi: {combustivel.CalculoCombustivel()}Km ");

            Console.ReadKey();
        }
    }
}
