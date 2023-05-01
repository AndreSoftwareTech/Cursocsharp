namespace Conversoress;
public class Conversores
{
    public void ConvertAndParse()
    {
        int NUMERO = int.Parse("1");

        int numero = Convert.ToInt32(null);

        bool verdadeiro = bool.Parse("true");

       

        Console.WriteLine(NUMERO);
        Console.WriteLine(numero);
        Console.WriteLine(verdadeiro);

    }

    public void TryParse()
    {
        var numero = "123456";
        int numeroConvertido;

        if (int.TryParse(numero, out numeroConvertido))
        {
            Console.WriteLine("Numero convertido");
        }
        Console.WriteLine(numeroConvertido);
    }

    
 }