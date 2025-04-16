class Deque
{
    Queue<int> fila = new Queue<int>();

   public void InserirTras(int valor)
    {
        fila.Enqueue(valor);
    }

    public void InserirFrente(int valor)
    {
     Queue<int> filaNova = new Queue<int>();
        filaNova.Enqueue(valor);
        foreach (var item in fila)
        {
            filaNova.Enqueue(item);
        }
        fila = filaNova;
    }

    public void RemoverFrente()
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("Deque vazio");
            return;
        }
        else
        {
            int removido = fila.Dequeue();
            Console.WriteLine("Removido: " + removido);
        }
    }

    public void RemoverTras()
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("Deque vazio");
            return;
        }
        else
        {
            Queue<int> filaNova = new Queue<int>();
            int removido = -1;
            while (fila.Count > 1)
            {
                filaNova.Enqueue(fila.Dequeue());
            }
            removido = fila.Dequeue();
            fila = filaNova;
            Console.WriteLine("Removido: " + removido);
        }
    }
    public void MostrarFila()
    {
        Console.WriteLine("Fila atual:");
        foreach (var item in fila)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        
    }

}

class Program
{
    static void Main(string[] args)
    {
        Deque deque = new Deque();

        deque.InserirTras(10);
        deque.InserirFrente(5);
        deque.InserirTras(20);
        deque.InserirFrente(1);

        deque.MostrarFila();

        deque.RemoverFrente();
        deque.RemoverTras();

        deque.MostrarFila();
    }
}