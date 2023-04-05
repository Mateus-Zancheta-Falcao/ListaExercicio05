using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            Console.WriteLine("- Calculo volume de um Cilindro -\n");

            Console.WriteLine("Informe o raio: ");
            cilindro.raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o a altura: ");
            cilindro.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nVolume do cilindro é: {cilindro.CalculoVolume()}cm");

            Console.ReadKey();
        }
    }
}
