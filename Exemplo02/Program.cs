//Informe a seu nome e idade e depois printe na tela.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    class Exemplo02
    {
        static void Main(string[] args)
        {
            int idade;
            string nome, aux;
            //Digitação e escaneamento da idade.
            Console.WriteLine("Digite sua idade:");
            aux = Console.ReadLine();
            idade = Convert.ToInt16(aux);
            //OU idade = Convert.ToInt16(Console.ReadLine());

            //Digitação e escaneamento do nome.
            Console.WriteLine("Digite se nome:");
            nome = Console.ReadLine();

            //Printar os resultados na tela.
            Console.WriteLine($"\n{nome} sua idade é {idade} anos.");
            //Ou Console.WritLine(nome +"você tem" idade + "anos.");   

            Console.ReadKey();
        }
    }
}
