﻿using System;
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

            //tipos primitivos sting aspas duplas, char aspas simples
            char flag = 'a';
            string nome = "Andre";
            flag = 'b';

            // duas variaveis do tipo int, diferenca esta na declaracao
            int idade = 25;
            var idadenova = 25;

            // booleano
            bool verdadeiro = true;

            // tipos primitivos flooat
            decimal valor = 100.99m;
            double valordois = 100.99;
            float valortrez = 100.99f;

            //constante é dado atraves da palavra reservada const, nao permitindo reatribuir um novo valor posteriormente apos a criacao
            const string descricao = "Curso Csharp"; 

            
            Console.WriteLine(flag);
            Console.WriteLine(nome);

            Console.WriteLine(idade);
            Console.WriteLine(idadenova);

            Console.WriteLine(verdadeiro);
            
            Console.WriteLine(valor);
            Console.WriteLine(valordois);
            Console.WriteLine( valortrez);
            Console.WriteLine(descricao);
            Console.ReadLine();
        }
    }
}
