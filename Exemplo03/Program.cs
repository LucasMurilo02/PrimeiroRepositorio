/*Eleva um número ao quadrado, utilizando uma operação manual
 ou um método pronto para a cçasse Math.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    class Exemplo03
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"\nO número {numero} elevado ao quadrado é {numero * numero}.");//OU
            Console.WriteLine($"\nO número {numero} elevado ao quadrado é {Math.Pow(numero, 2)}.");

            Console.ReadKey();
        }
    }
}
