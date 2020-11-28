//Receba a largura e um comprimento digitados e calcule a área total de um terreno
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo05
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento;

            Console.WriteLine("Forneça a largura:");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Forneça o comprimento:");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A área correspondente a essas medidas é igual a {largura * comprimento} metros quadrados.");

            Console.ReadKey();
        }
    }
}
