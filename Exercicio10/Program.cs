using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada media = new MediaPonderada();

            Console.WriteLine("- Descubra a média pondera -\n");

            Console.WriteLine("A primeira terá o peso de 5 e a segunda também será 5!");

            Console.WriteLine("Informe a primeira nota: ");
            media.N1 = Convert.ToDouble(Console.ReadLine()); //N = notas

            Console.WriteLine("Informe a segunda nota: ");
            media.N2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A média ponderada é: {media.CalculoMediaPonderada()}");

            Console.ReadKey();
        }
    }
}
