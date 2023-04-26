using System.ComponentModel;

var i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
    //condicao para continuar atraves da persistencia
    if (i < 5)
    {
        Console.WriteLine("continue.....");
        i++;
        continue;
    }
    Console.WriteLine("continue.....");
    i++;
    // ultilizando o break dentro de uma estrutura ele interrompe o laco de repeticao
    if (i == 5)
    {
        Console.WriteLine("Igual ao indice 2");
        break;
     }
}