using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumento;

            Console.WriteLine("Informe o valor do salário atual do funcionário e logo em seguida informe o percentual de aumento:");
            salario = Convert.ToDouble(Console.ReadLine());
            aumento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor de acréscimo do aumento salarial será equivalente a {Math.Round(((salario + (salario * (aumento / 100))) - salario),2).ToString()}, tendo agora um salário de {Math.Round((salario + (salario * (aumento / 100))),2).ToString()}.");

            Console.ReadKey();
        }
    }
}
