//Transforma a quantidade de dias em anos.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    class Exemplo04
    {
        static void Main(string[] args)
        {
            double dias;
            double anos;

            Console.WriteLine("Entre com o número de dias:");
            dias = Convert.ToDouble(Console.ReadLine());
            anos = dias / 365.25;

            Console.WriteLine($"\n {dias} dia(s) equivale(m) a {anos} ano(s)");

            Console.ReadKey();
        }
    }
}
