namespace Cadastro
{


    public static class Calculos
    {
        public static int Soma(int a, int b)
        {
            return a + b;
        }

    }

    public class Produto
    {
        private int id;
        public string descricao { get; set; }

        public readonly int Estoque;

        public Produto() 
        {
            Estoque = 2;
        }

        public void imprimir()
        {
            Console.WriteLine(getId() + descricao);
        }

        public void setId(int id)
        { id = id; }
        public int getId()
        { return id; }
    }


    public class Pessoa 
    { 
        private int id { get; set; }
        public string Endereco { get; set;}

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public void imprimir()
        {
            Console.WriteLine("identificador" + id);
            Console.WriteLine("Endereco" + Endereco);
            Console.WriteLine("Cidade" + Cidade);
            Console.WriteLine("Cep" + Cep);



        }


    }
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void imprimircpf()
        {
            Console.WriteLine("CPF" + CPF);


        }

        public class Funcionario : PessoaFisica 
        {
            public string Nome { get; set; }

            public void imprimirNome()
            {
                Console.WriteLine("Nome " + Nome);


            }

        }

    }
}
