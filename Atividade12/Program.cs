Stack <int> pilha = new Stack<int>();

Console.Write("Digite um número decimal: ");
int numeroDecimal = int.Parse(Console.ReadLine());


Console.Write("Número binário: ");

while (numeroDecimal > 0)
{
    int resto = numeroDecimal % 2;
    pilha.Push(resto);
    numeroDecimal /= 2;
}

while (pilha.Count > 0)
{
    Console.Write(pilha.Pop());
}
Console.WriteLine();
