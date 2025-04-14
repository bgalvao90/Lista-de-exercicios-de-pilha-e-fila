using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();

        Console.Write("Digite os elementos (separados por espaço): ");
        string elementos = Console.ReadLine();

        foreach (string elemento in elementos.Split(' '))
        {
            fila.Enqueue(elemento);
        }

        Stack<string> pilha = new Stack<string>();
        while (fila.Count > 0)
        {
            pilha.Push(fila.Dequeue());
        }

        Console.Write("Elementos na pilha: ");
        while (pilha.Count > 0)
        {
            Console.Write(pilha.Pop() + " ");
        }
    }
}