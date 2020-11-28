using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double distância;
            double velocidade;

            Console.WriteLine("Informe a distância a ser percorrida pelo automóvel em kilômetros:");
            distância = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a velocidade atingida pelo automóvel em kilômetros por hora:");
            velocidade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O tempo que o automóvel levará para completar esse percurso será de {distância/velocidade} horas.");

            Console.ReadKey();
        }
    }
}
