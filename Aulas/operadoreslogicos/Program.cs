// operadores logicos

int n1 = 1;
int n2 = 2;


// & siguinifica and , isso representa se uma duas alternativas estiverem incorretas o resultado nao sera valido.
bool valido = n2 > n1 && 8 > 7;

// & siguinifica ou , isso significa que se uma das duas alternativas estiverem validas o resultado sera valido.
bool valido2 = n2 > n1 || 8 > 7;

// ! siguinifica negacao, o ponto de exclamacao usado sozinho siguinifica operador de negacao n2 nao e maior que dez.
bool valido3 = !(n2 > 10 );


Console.WriteLine(valido);
Console.WriteLine(valido2);
Console.WriteLine(valido3);


