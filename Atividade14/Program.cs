using System;
using System.Collections.Generic;
using System.Linq;

enum Prioridade
{
    Alta = 0,
    Media = 1,
    Baixa = 2
}

class FilaPrioridade<T>
{
    private List<(T item, Prioridade prioridade)> fila = new List<(T item, Prioridade prioridade)>();

    public void Enfileirar(T item, Prioridade prioridade)
    {
        fila.Add((item, prioridade));
        fila = fila.OrderBy(x => x.prioridade).ToList();
    }

    public T Desenfileirar()
    {
        if (fila.Count == 0)
            throw new InvalidOperationException("A fila está vazia.");
        T item = fila[0].item;
        fila.RemoveAt(0);
        return item;
    }

    public T Espiar()
    {
        if (fila.Count == 0)
            throw new InvalidOperationException("A fila está vazia.");
        return fila[0].item;
    }

    public int Count() => fila.Count;
}

class Program
{
    static void Main(string[] args)
    {
        FilaPrioridade<string> fila = new FilaPrioridade<string>();
        fila.Enfileirar("Tarefa 1", Prioridade.Alta);
        fila.Enfileirar("Tarefa 2", Prioridade.Baixa);
        fila.Enfileirar("Tarefa 3", Prioridade.Media);
        Console.WriteLine("Total de itens na fila: " + fila.Count());
        Console.WriteLine("Elemento do topo da fila: " + fila.Espiar());
        Console.WriteLine("Removendo o elemento do topo da fila: " + fila.Desenfileirar());
        Console.WriteLine("Total de itens na fila: " + fila.Count());
    }
}