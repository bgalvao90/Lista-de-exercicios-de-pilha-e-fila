using System;
using System.Collections.Generic;

class LRUCache
{
    private int capacidadeMaxima;
    private Queue<int> filaDeCache = new();
    private HashSet<int> conjuntoDeItens = new();

    public LRUCache(int capacidadeMaxima) => this.capacidadeMaxima = capacidadeMaxima;

    public void AcessarItem(int item)
    {
        if (conjuntoDeItens.Contains(item))
        {
            Console.WriteLine($"Item {item} já está no cache.");
            return;
        }

        if (filaDeCache.Count >= capacidadeMaxima)
        {
            int itemRemovido = filaDeCache.Dequeue();
            conjuntoDeItens.Remove(itemRemovido);
            Console.WriteLine($"Item {itemRemovido} removido do cache.");
        }

        filaDeCache.Enqueue(item);
        conjuntoDeItens.Add(item);
        Console.WriteLine($"Item {item} adicionado ao cache.");
    }

    public void ExibirCache()
    {
        Console.WriteLine("Cache atual:");
        foreach (var item in filaDeCache)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        LRUCache cache = new(3);

        cache.AcessarItem(1);
        cache.AcessarItem(2);
        cache.AcessarItem(3);
        cache.ExibirCache();
        cache.AcessarItem(4);
        cache.AcessarItem(2);
        cache.AcessarItem(5);
        cache.ExibirCache();
    }
}