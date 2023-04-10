//Dicionario  conceito de chave e valor onde a chave nao se repete
var dicionario = new Dictionary<string, string>()
{
    { "preimeiro", "Andre"},
    { "Segundo", "Vitor"},
    { "terceiro", "Granemann"},

};


dicionario.Add("Quarto", "Belli");



foreach (var item in dicionario)
{
    Console.WriteLine(item.Value);

}
