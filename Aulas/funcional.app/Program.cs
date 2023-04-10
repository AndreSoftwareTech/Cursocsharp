// Trabalhando com funcoes

// Variavel recebendo a funcao 
var nome1 = NomeCompleto();

var nome2 = NomeCompleto2();

var soma = Soma(5, 5);







//funcao com retorno de uma string
string NomeCompleto()
{
    return "Andre Vitor Granemann Belli";
}

string NomeCompleto2()
{
    string nome = "Andre";
    string sobrenome = "Granemann";
    return nome + " " + sobrenome;
}

// funcao com parametros
int Soma(int a, int b)

{ 
    return a + b;
}



Console.WriteLine(nome1);
Console.WriteLine(nome2);
Console.WriteLine(soma);

