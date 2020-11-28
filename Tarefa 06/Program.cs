using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            Console.WriteLine("Informe o valor do salário vigente do funcionário:");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O salário informado com um reajuste de 25% a mais será de {Math.Round((salario + (salario * 0.25)),2).ToString()}.");

            Console.ReadKey();
        }
    }
}
