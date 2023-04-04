using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class MediaPonderada
    {
        public static double N1 { get; set; }
        public static double N2 { get; set; }
        public static double mediaPonderada { get; set; }

        public static void CalculoMediaPonderada()
        {
            Console.WriteLine("- Descubra a média pondera -\n");

            Console.WriteLine("A primeira terá o peso de 5 e a segunda também será 5!");

            Console.WriteLine("Informe a primeira nota: ");
            N1 = Convert.ToDouble(Console.ReadLine()); //N = notas

            Console.WriteLine("Informe a segunda nota: ");
            N2 = Convert.ToDouble(Console.ReadLine());

            mediaPonderada = (N1 * 1) + (N2 * 1) / 2;

            Console.WriteLine($"A média ponderada é: {mediaPonderada}");

            Console.ReadKey();
        }
    }
}
