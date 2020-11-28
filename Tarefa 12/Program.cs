using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double cigarropordia;
            double anosquefuma;

            Console.WriteLine("Informe a seguir quantos cigarros por dia a pessoa consome e logo em seguida a quantidade de anos que isso já ocorre:");
            cigarropordia = Convert.ToDouble(Console.ReadLine());
            anosquefuma = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A quantidade de dias que esse fumante perderá de vida será equivalente a {Math.Round(cigarropordia*anosquefuma*365*0.007,0).ToString()}.");
            //0.007 é aproximadamente a proporção de 10 minutos em um dia.

            Console.ReadKey();
        }
    }
}
