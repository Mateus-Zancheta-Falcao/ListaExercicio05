using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Lata
    {
        public static double pi { get; set; }
        public static double raio { get; set; }
        public static double altura { get; set; }
        public static double volume { get; set; }

        public static void CalculoLata()
        {
            pi = 3.14;

            Console.WriteLine("- Calculo volume de uma lata de óleo -\n");

            Console.WriteLine("Informe o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = pi * (raio * raio) * altura;

            Console.WriteLine($"\nVolume da lata é: {volume}cm");

            Console.ReadKey();
        }
    }
}
