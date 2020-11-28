using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double pesonota1;
            double pesonota2;
            double pesonota3;

            Console.WriteLine("Informe o valor da primeira nota e em seguida seu respectivo peso:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            pesonota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da segunda nota e em seguida seu respectivo peso:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            pesonota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor da terceira nota e em seguida seu respectivo peso:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            pesonota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor da média ponderada das três notas informadas é de {((nota1 * pesonota1) + (nota2 * pesonota2) + (nota3 * pesonota3)) / (pesonota1 + pesonota2 + pesonota3)}.");

            Console.ReadKey();
        }
    }
}
