// stack conceito de ultimo a entrar na pilha é o primeiro a sair

var stack = new Stack<string>();
stack.Push("Andre");
stack.Push("Vitor");

foreach (var item in stack)
{
    Console.WriteLine(item);
}

