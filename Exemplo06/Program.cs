//Conversão de polegadas para centímetros.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    class Exemplo06
    {
        static void Main(string[] args)
        {
            double polegadas;

            Console.WriteLine("Digite o valor em polegadas:");
            polegadas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{polegadas} polegada(s) equivale(m) a {polegadas * 2.54} centímetros.");

            Console.ReadKey();
        }
    }
}
