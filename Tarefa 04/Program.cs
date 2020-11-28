using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros;
            double milímetros;

            Console.WriteLine("Insira o valor em metros a ser convertido:");
            metros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor de {metros} metros é equivalente a {metros * 1000} milímetros.");

            Console.ReadKey();
        }
    }
}
