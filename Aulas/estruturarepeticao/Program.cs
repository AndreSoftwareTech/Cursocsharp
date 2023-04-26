

// Variavel lista recebendo dados fixos 
var lista = new List<string>()
{
    "Andre",
    "Vitor",
    "Granemann",
    "Belli",
    "Pereira"
};

// estrutura repeticao recebendo variavel i que representa o indice de inicializacao ; para finalizar primeira parte do processo
// variavel do indice recebendo a variavel lista ponto Count que siguinifica tamanho da lista e o indice para incremento
for(var i = 0; i < lista.Count; i++)
{
    var nome = lista[i];

    Console.WriteLine(nome);

}


