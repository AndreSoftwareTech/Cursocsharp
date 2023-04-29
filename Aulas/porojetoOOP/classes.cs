namespace Cadastro
{
    // classe estatica

    public static class Calculos
    {
        public static int Soma(int a, int b)
        {
            return a + b;
        }

    }

    // Classe normal
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

    // Classe mae
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

    //Classe filha (Pessoa) 
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void imprimircpf()
        {
            Console.WriteLine("CPF" + CPF);


        }

    

    }


    //Classe Filha (Pessoa Fisica) 
    public class Funcionario : PessoaFisica
    {
        public string Nome { get; set; }

        public void imprimirNome()
        {
            Console.WriteLine("Nome " + Nome);


        }

    }



    //Classe Selada "Nao Permite heranca"
    public sealed class Configuracao
    {
    public string Host { get; set;}

        public void imprimirhost()
        {
            Console.WriteLine("Host" + Host);


        }
    }

    //Classe Abstrata 
    public abstract class Animal
    {
        public string Nome { get; set;}

        public abstract string GetInformacoes();

        public void imprimiranimal()
        {
            Console.WriteLine("Nome do Animal " + Nome);
            Console.WriteLine("Informacoes " + GetInformacoes());
        }

    }

    //classe abstrata da classe animal
    public class Cachorro : Animal
    {
       
        public override string GetInformacoes()
        {
            return "Cachorro e um bom amigo";
        }
    }


    //Reord
    public record Curso(int Id, string Descricao);


    public interface INotificacao
    {
        string descricao { get; set; }

        void Notificar();
    }

    public class NotificarCliente : INotificacao
    {
        public string descricao { get;  set; }
        

        public void Notificar()
        {
            Console.WriteLine("Notificando CLiente");
        }
    }
    
}

    
