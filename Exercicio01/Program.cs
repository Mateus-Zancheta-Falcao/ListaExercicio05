using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

            Console.WriteLine("- Calculo da caixa de um retângulo -\n");

            Console.WriteLine("Informe o comprimento: ");
            caixa.comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura: ");
            caixa.largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o comprimento: ");
            caixa.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nO volume da caixa é: {caixa.CalcularCaixa()} cm");

            Console.ReadKey();
        }
    }
}
