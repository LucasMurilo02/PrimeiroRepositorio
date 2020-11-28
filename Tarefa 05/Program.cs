using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias;
            int horas;
            int minutos;
            int segundos;

            Console.WriteLine("Informe a quantidade de dias do período:");
            dias = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas do período:");
            horas = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de minutos do período:");
            minutos = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de segundos do período:");
            segundos = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"A quantidade de segundos totais do tempo decorrido descrito é de {segundos + (minutos * 60) + (horas * 3600) + (dias * 86400)}.");

            Console.ReadKey();
        }
    }
}
