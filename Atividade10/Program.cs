using System;

namespace Atividade10
{
    class Program
    {
        static void Main()
        {
            MinhaPilha<int>.Push(1);
            MinhaPilha<int>.Push(2);
            MinhaPilha<int>.Push(3);

            Console.WriteLine("Total de itens na pilha: " + MinhaPilha<int>.Count());
            Console.WriteLine("Elemento do topo da pilha: " + MinhaPilha<int>.Peek());

            Console.WriteLine("Removendo o elemento do topo da pilha: " + MinhaPilha<int>.Pop());
            Console.WriteLine("Total de itens na pilha: " + MinhaPilha<int>.Count());
        }
    }
}


static class MinhaPilha<T>
{
    private static List<T> pilha = new List<T>();

    public static void Push(T item) => pilha.Add(item);

    public static T Pop()
    {
        if (pilha.Count == 0)
            throw new InvalidOperationException("A pilha está vazia.");
        T item = pilha[pilha.Count - 1];
        pilha.RemoveAt(pilha.Count - 1);
        return item;
    }

    public static int Count() => pilha.Count;

    public static T Peek()
    {
        if (pilha.Count == 0)
            throw new InvalidOperationException("A pilha está vazia.");
        return pilha[pilha.Count - 1];
    }
}
