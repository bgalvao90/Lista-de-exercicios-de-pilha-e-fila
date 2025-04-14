using System;

class FilaCircular<T>
{
    private T[] _fila;
    private int _inicio;
    private int _fim;
    private int _tamanho;
    private int _capacidade;

    public FilaCircular(int capacidade)
    {
        _capacidade = capacidade;
        _fila = new T[capacidade];
        _inicio = 0;
        _fim = -1;
        _tamanho = 0;
    }

    public bool EstaVazia => _tamanho == 0;

    public bool EstaCheia => _tamanho == _capacidade;

    public void Enfileirar(T item)
    {
        if (EstaCheia)
        {
            throw new InvalidOperationException("A fila está cheia.");
        }

        _fim = (_fim + 1) % _capacidade;
        _fila[_fim] = item;
        _tamanho++;
    }

    public T Desenfileirar()
    {
        if (EstaVazia)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        T item = _fila[_inicio];
        _inicio = (_inicio + 1) % _capacidade;
        _tamanho--;
        return item;
    }

    public T Espiar()
    {
        if (EstaVazia)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        return _fila[_inicio];
    }
}

class Program
{
    static void Main(string[] args)
    {
        var fila = new FilaCircular<int>(5);

        fila.Enfileirar(1);
        fila.Enfileirar(2);
        fila.Enfileirar(3);
        fila.Enfileirar(4);
        fila.Enfileirar(5);

        Console.WriteLine(fila.Desenfileirar()); 
        Console.WriteLine(fila.Desenfileirar()); 

        fila.Enfileirar(6);
        fila.Enfileirar(7);

        while (!fila.EstaVazia)
        {
            Console.WriteLine(fila.Desenfileirar());
        }
    }
}