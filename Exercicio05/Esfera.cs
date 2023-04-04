using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Esfera
    {
        public static double pi { get; set; }
        public static double raio { get; set; }
        public static double altura { get; set; }
        public static double volume { get; set; }


        public static void CalculoEsfera()
        {
            pi = 3.14;

            Console.WriteLine("- Calculo volume de uma Esfera -\n");

            Console.WriteLine("Informe o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4 * pi * Math.Pow(raio, 3)) / 3;

            volume = Math.Round(volume, 2);

            Console.WriteLine($"\nVolume da esfera é: {volume}cm");

            Console.ReadKey();
        }
    }
}
