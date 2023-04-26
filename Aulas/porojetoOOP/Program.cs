

using System;
using Cadastro;

namespace projeto
{
    public class projeto
    {
        static void Main(string[] args)
        {
           var resultado = Cadastro.Calculos.Soma(2, 3);
                        
            Console.WriteLine(resultado);

            Description();
            Estoquefunction();

            Heranca();  
        }



        private static void Description()
        {
            var produto = new Cadastro.Produto();
            produto.descricao = "Teclado";
            produto.setId(1);
            produto.imprimir();

            Console.WriteLine(produto.getId());

        }
        private static void Estoquefunction()
        {
            var estoque = new Cadastro.Produto();
            
            Console.WriteLine(estoque.Estoque);
        }

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



    }



}
