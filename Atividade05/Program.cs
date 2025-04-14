using System.Linq;

Console.Write("Digite uma palavra:");
string palavra = Console.ReadLine();

Stack<char> pilha = new Stack<char>();
foreach (char letra in palavra)
{
    pilha.Push(letra); 
}
Console.Write("Palavra invertida:");
while (pilha.Count > 0)
{
    Console.Write(pilha.Pop());
}