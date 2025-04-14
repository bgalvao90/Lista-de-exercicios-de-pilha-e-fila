using System;

Stack<string> historico = new Stack<string>();

string opcao = string.Empty;
do
{
    Console.WriteLine("Home");
    if (historico.Count > 0)
    {
        Console.WriteLine("Ultima URL acessada: " + historico.Peek());
    }
    else
    {
        Console.WriteLine("Nenhuma URL acessada.");
    }
    Console.Write("Digite uma URL:");
    string url = Console.ReadLine();
    historico.Push(url);
    Console.WriteLine("Deseja adicionar mais uma URL? (s/n)");
    opcao = Console.ReadLine();
} while (opcao.ToLower() == "s");

Console.WriteLine("Ultima URL acessada: " + historico.Peek());