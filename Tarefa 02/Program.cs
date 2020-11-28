using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A média aritmética das três notas digitas é de {(nota1 + nota2 + nota3) / 3}.");

            Console.ReadKey();
        }
    }
}
