


using Conversoress;

namespace projeto
{
    public class projeto
    {
        static void Main(string[] args)
        {
            Conversores();

        }

        private static void Conversores() 
        {
             var conversores = new Conversores();
            conversores.ConvertAndParse();
            conversores.TryParse();
        }

    }

}
