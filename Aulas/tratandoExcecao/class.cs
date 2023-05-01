
namespace Modulo12
{
    public class Work
    {

        public static void AulaExcessao()
        {

            while (true)
            {
                try
                {

                    var numero = Console.ReadLine();
                    var resultado = 500 / int.Parse(numero);
                    Console.WriteLine(resultado);
                }
                catch(Exception exeception)
                {
                    Console.WriteLine("Ocorreu um Erro" + exeception.Message);
                }

            }
    }
      
    }
}
