using System.Collections;

var arrayList = new ArrayList();

arrayList.Add(1); //indice 0

arrayList.Add("Andre");  //indice 1

arrayList.Add(true); //indice 2

//funcao interna para remover apenas um indice
arrayList.RemoveAt(0);

//funcao para limpar o Array List
arrayList.Clear();

//estrutura de repeticao para o indice do array List
foreach (var item in arrayList)
{
    Console.WriteLine(item);
}
//Console.WriteLine(arrayList[2]);
