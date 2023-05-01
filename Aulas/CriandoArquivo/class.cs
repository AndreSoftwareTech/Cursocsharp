
namespace Modulo12
{
    public class Work
    {

        public static void AulaCriandoArquivo()
        {
            var escrever = new StreamWriter("Cadastro.txt", true);
            Console.Write("Informe Um Nome ");
            var nome = Console.ReadLine();
            escrever.WriteLine("ID....: " + Random.Shared.Next(1, 100));
            escrever.WriteLine("Nome: " + nome);
            escrever.WriteLine("-----------------------------------------");
            escrever.Close();

        }

    }
}
