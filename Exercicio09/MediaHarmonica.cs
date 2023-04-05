using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class MediaHarmonica
    {
        public int quantidadeDeNotas { get; set; }
        public double DivisãoNotas { get; set; }
        public double MediaFinal { get; set; }
        public double media { get; set; }
        public double nota { get; set; }
        public double MediaH { get; set; }

        public double CalculoMediaHarmonica()
        {
            for (int i = 0; i < quantidadeDeNotas; i++)
            {
                Console.WriteLine("Informe uma nota: ");
                nota = Convert.ToDouble(Console.ReadLine());

                media = 1 / nota;
                media = MediaFinal + media;
            }

            MediaH = quantidadeDeNotas / MediaFinal;

            return MediaH;
            
        }
    }
}
