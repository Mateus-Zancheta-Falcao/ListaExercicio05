using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class MediaHarmonica
    {
        public static int quantidadeDeNotas { get; set; }
        public static double DivisãoNotas { get; set; }
        public static double MediaFinal { get; set; }
        public static double media { get; set; }
        public static double nota { get; set; }
        public static double MediaH { get; set; }

        public static void CalculoMediaHarmonica()
        {
            Console.WriteLine("- Calculo média harmônica - \n");

            Console.WriteLine("Informe a quantidade de notas: ");
            quantidadeDeNotas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                Console.WriteLine("Informe uma nota: ");
                nota = Convert.ToDouble(Console.ReadLine());

                media = 1 / nota;
                media = MediaFinal + media;
            }

            MediaH = quantidadeDeNotas / MediaFinal;

            Console.WriteLine($"A média harmônica é: {MediaH}");

            Console.ReadLine();
        }
    }
}
