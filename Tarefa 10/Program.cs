using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius;

            Console.WriteLine("Informe o valor em graus celsius a ser convertido:");
            celsius = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"O valor em graus celsius informado em farenheight será de {(celsius*9 / 5) + 32} graus.");

            Console.ReadKey();
        }
    }
}
