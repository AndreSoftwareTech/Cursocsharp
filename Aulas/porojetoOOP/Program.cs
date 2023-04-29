

using System;
using Cadastro;

namespace projeto
{
    public class projeto
    {
        static void Main(string[] args)
        {
           //var resultado = Cadastro.Calculos.Soma(2, 3);
                        
            //Console.WriteLine(resultado);

            //Description();
            //Estoquefunction();

            //Heranca();

            //SELADA();

            //Abstrato();

            // Record();
            AulaInterface();

        }




        // metodo para manter codigo da classe produto
        private static void Description()
        {
            var produto = new Cadastro.Produto();
            produto.descricao = "Teclado";
            produto.setId(1);
            produto.imprimir();

            Console.WriteLine(produto.getId());

        }

        // acessando a instancia da classe produto e atribuindo valor para o estoque sem o set
        private static void Estoquefunction()
        {
            var estoque = new Cadastro.Produto();
            
            Console.WriteLine(estoque.Estoque);
        }


        // metodo ultilizando conceito de heranca
        private static void Heranca()
        {
            var pessoa = new Cadastro.PessoaFisica();
            pessoa.Endereco = "Dom Duarte";
            pessoa.Cidade = "Blumenau";
            pessoa.Cep = "89510-110";
            pessoa.CPF = "123456";

            pessoa.imprimir();
            pessoa.imprimircpf();
        }

        // metodo ultilizando o conceito de classe selada
        private static void SELADA()
        {
            var configuracao = new Cadastro.Configuracao();
            configuracao.Host = "Local";
            configuracao.imprimirhost();

        }

        // metodo ultilizando o conceito de classe abstrata
        private static void Abstrato()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Dougo";
            cachorro.imprimiranimal();  
        }

        private static void Record()
        {

            //segunda forma de atribuir dados sem ultilizar  instancia de uma classe
            var curso1 = new Cadastro.Curso( 1, "Curso" );
            var curso2 = new Cadastro.Curso(1, "Curso");


            Console.WriteLine(curso1.Equals(curso2));


        }

        private static void AulaInterface()
        {
            var notificar = new Cadastro.NotificarCliente();
            notificar.Notificar();
        }

    }

}
