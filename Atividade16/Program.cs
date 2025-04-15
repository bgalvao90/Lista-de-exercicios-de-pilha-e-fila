class Deque
{
    Queue<int> queue = new Queue<int>();
    Queue<Queue<int>> queueAux = new Queue<Queue<int>>();

    public void Enqueue(int item)
    {
        queue.Enqueue(item);
        var itemAux = new Queue<int>(queue);
        queueAux.Enqueue(itemAux);
    }
    public void Dequeue()
    {
        if (queue.Count == 0 && queueAux.Count == 0)
            throw new InvalidOperationException("A fila está vazia.");
        queue.Dequeue();
        queueAux.Dequeue();

    }

    public void MostrarFila()
    {
        Console.WriteLine("Fila atual:");
        foreach (var item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Fila Secundaria: ");
        foreach (var item in queueAux)
        {
            Console.Write(item + " ");
            
        }


    }

}

class Program
{
    static void Main(string[] args)
    {
        Deque deque = new Deque();
        deque.Enqueue(1);
        deque.Enqueue(2);
        deque.Enqueue(3);
        deque.MostrarFila();
        deque.Dequeue();
        deque.MostrarFila();
    }
}