using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas.App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Andre";
            int idade = 25;
            decimal valor = 100.99m;
            double valordois = 100.99;
            float valortrez = 100.99f;
            var idadenova = 25;


            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(valor);
            Console.WriteLine(valordois);
            Console.WriteLine( valortrez);
            Console.WriteLine(idadenova);

            Console.ReadLine();
        }
    }
}
