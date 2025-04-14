using System.Linq;

Queue<string> ordemDeChegada = new Queue<string>();
Console.Write("Digite a quantidade de clientes: ");
int quantidade = int.Parse(Console.ReadLine());
for (int i = 0; i < quantidade; i++)
{
    Console.Write("Digite o nome do cliente: ");
    string nome = Console.ReadLine();
    ordemDeChegada.Enqueue(nome);
}

foreach (string nome in ordemDeChegada)
{
    int posicao = ordemDeChegada.ToList().IndexOf(nome) + 1;
    Console.WriteLine("Cliente " + nome +" é o " + posicao + "° "+ " na fila.");
}