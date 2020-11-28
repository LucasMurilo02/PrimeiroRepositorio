using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Digite o valor do primeiro número inteiro:");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo número inteiro:");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"O valor da soma dos dois números inseridos é de {num1 + num2}.");

            Console.ReadKey();
        }
    }
}
