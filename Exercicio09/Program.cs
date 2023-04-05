using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica media = new MediaHarmonica();

            Console.WriteLine("- Calculo média harmônica - \n");

            Console.WriteLine("Informe a quantidade de notas: ");
            media.quantidadeDeNotas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A média harmônica é: {media.CalculoMediaHarmonica()}");

            Console.ReadLine();
        }
    }
}
