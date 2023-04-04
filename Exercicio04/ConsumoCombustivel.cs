using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class ConsumoCombustivel
    {
        public static double QuilometragemInicial { get; set; }
        public static double QuilometragemFinal { get; set; }
        public static double QuantidadeComb { get; set; }
        public static double Consumo { get; set; }

        public static void CalculoCombustivel()
        {
            Console.WriteLine("- Calculadora para o consumo de combustível por Km -\n");

            Console.Write("Informe a quilometragem inicial: ");
            QuilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quilometragem final: ");
            QuilometragemFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quantidade de combustível: ");
            QuantidadeComb = Convert.ToDouble(Console.ReadLine());

            Consumo = (QuilometragemInicial + QuilometragemFinal) / QuantidadeComb;

            Consumo = Math.Round(Consumo, 2);

            Console.WriteLine($"\nO consumo de combustível foi: {Consumo}Km ");

            Console.ReadKey();
        }
    }
}
