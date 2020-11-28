using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double preço;
            double desconto;

            Console.WriteLine("Informe o valor da mercadoria e logo em seguida informe o percentual de desconto:");
            preço = Convert.ToDouble(Console.ReadLine());
            desconto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor descontado do produto será de {Math.Round((preço * (desconto / 100)), 2).ToString()} e o valor final do produto será de {Math.Round((preço - (preço * (desconto / 100))), 2).ToString()}.");

            Console.ReadKey();
        }
    }
}
