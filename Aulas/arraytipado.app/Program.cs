// array com tipo primitivo pré defindio
var arrayList = new int[3] {1, 2, 3};

// acessando o array e alterando o valor do indice 0 de 1 para 5
arrayList[0] = 5;
arrayList[1] = 5;
arrayList[2] = 5;

// biblioteca para alterar tamanho de indices de um array, por padrao default os indices serao preenchidos em 0
Array.Resize(ref arrayList, 20);
arrayList[10] = 10;



//estrutura de repeticao para o indice do array List
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}
Console.WriteLine(arrayList);
