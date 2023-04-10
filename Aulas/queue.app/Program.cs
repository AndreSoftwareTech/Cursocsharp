// queue 
var queue = new Queue<string>();

//criando uma queue
queue.Enqueue("Andre");
queue.Enqueue("Vitor");

//usando metodo dequeue da classe generia queue
var nome = queue.Dequeue();
var nome1 = queue.Dequeue();


//acessando de forma generica toda queue
Console.WriteLine(nome);
Console.WriteLine(nome1);
