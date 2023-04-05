using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            Console.WriteLine("- Calculo volume de uma Esfera -\n");

            Console.WriteLine("Informe o raio: ");
            esfera.raio = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"\nVolume da esfera é: {esfera.CalculoEsfera()}cm");

            Console.ReadKey();
        }
    }
}
