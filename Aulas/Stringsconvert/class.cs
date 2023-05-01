
namespace Modulo10
{
    public class Work
    {
       
        public static  void StringsFunLow()
        {
            Console.Write("Favor digitar Alguma Informacao >>> ");

            var linha = Console.ReadLine();

            Console.WriteLine(linha.ToLower());
        }

        public static void StringsFunUpper()
        {
            Console.Write("Favor digitar Alguma Informacao >>> ");

            var linha = Console.ReadLine();

            Console.WriteLine(linha.ToUpper());
        }

        public static void StringsFunSub()
        {
            Console.Write("Favor digitar Alguma Informacao >>> ");

            var linha = Console.ReadLine();
            //SubString serve para retornar o valor no conceito de inicio e fim 
            Console.WriteLine(linha.Substring(5));
        }

        public static void StringsFunRange()
        {
            string nomeArquivo = "2023_04_29_backup_bak";


            var ano = nomeArquivo[..4];
            Console.WriteLine(ano);

            var mes = nomeArquivo[5..^14];
            Console.WriteLine(mes);


            var dia = nomeArquivo[8..^11];
            Console.WriteLine(dia);


        }

        public static void StringsFunConteins()
        {
            string nomeArquivo = "2023_04_29_backup_bak";

            

            if (nomeArquivo.Contains("backup"))
            {
                Console.WriteLine("Nome existente");
            }
            else
            {
                Console.WriteLine("Nome inexistente");
            }


        }


        public static void AulaTrim()
        {
            string teste = "**Andre Vitor**";

            Console.WriteLine("Total" + teste.Trim('*'));
            Console.WriteLine("Inicio " + teste.TrimStart('*'));
        }

        public static void AulaStartWithEndswith()
            
        {

            string teste = "Curso Csharp";
            Console.WriteLine("Inicio: " + teste.StartsWith("Curso"));
            Console.WriteLine("Final " + teste.EndsWith("Csharp1"));
        }

        public static void AulaReplace()
        {
            string teste = "Curso Csharp";

            Console.WriteLine(teste);
            Console.WriteLine(teste.Replace("Csharp", "C#"));
        }

        public static void AulaLength()
        {
            string teste = Console.ReadLine();

            Console.WriteLine(teste);
            Console.WriteLine(teste.Length);
        }
    }
}
