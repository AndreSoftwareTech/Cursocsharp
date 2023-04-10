// Lista generica com definicao de tipo e tamanho do indice
var lista = new List<string>(10);


lista.Add("Andre");
lista.Add("Vitor");
lista.Add("Granemann");
lista.Add("Belli");

lista.RemoveAt(0);

var nome = lista[0];

Console.WriteLine(nome);

