using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class CaixaRetangular
    {
        public static double comprimento { get; set; }
        public static double largura { get; set; }
        public static double altura { get; set; }

        public static void CalculoCaixaRetangular()
        {
            Console.WriteLine("- Calculo da caixa de um retângulo -\n");

            Console.WriteLine("Informe o comprimento: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura: ");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o comprimento: ");
            altura = Convert.ToDouble(Console.ReadLine());

            double Volume = comprimento * largura * altura;

            Console.WriteLine($"\nO volume da caixa é: {Volume} cm");

            Console.ReadKey();
        }
    }
}
