using System;

namespace Atividade11
{
    class Program
    {
        static void Main()
        {
            MinhaFila<int> fila = new MinhaFila<int>();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);

            Console.WriteLine("Total de itens na fila: " + fila.Count());
            Console.WriteLine("Elemento do topo da fila: " + fila.Peek());
            Console.WriteLine("Removendo o elemento do topo da fila: " + fila.Dequeue());
            Console.WriteLine("Total de itens na fila: " + fila.Count());
        }
    }

    class MinhaFila<T>
    {
        private List<T> fila = new List<T>();
        public void Enqueue(T item) => fila.Add(item);

        public T Dequeue()
        {
            if (fila.Count == 0)
                throw new InvalidOperationException("A fila está vazia.");
            T item = fila[0];
            fila.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (fila.Count == 0)
                throw new InvalidOperationException("A fila está vazia.");
            return fila[0];
        }

        public int Count() => fila.Count;
    }
}