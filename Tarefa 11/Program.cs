using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double distância;
            int dias;

            Console.WriteLine("Informa a distância em kilômetros percorrida pelo carro e em seguida a quantidade de dias pelos quais ele foi alugado.");
            distância = Convert.ToDouble(Console.ReadLine());
            dias = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"O total a pagar pelo veículo alugado será de {Math.Round((distância * 0.15) + (dias * 60), 2).ToString()}.");

            Console.ReadKey();
        }
    }
}
