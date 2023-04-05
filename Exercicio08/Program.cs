using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lata lata = new Lata();

            Console.WriteLine("- Calculo volume de uma lata de óleo -\n");

            Console.WriteLine("Informe o raio: ");
            lata.raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o a altura: ");
            lata.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nVolume da lata é: {lata.CalculoLata()}cm");

            Console.ReadKey();
        }
    }
}
