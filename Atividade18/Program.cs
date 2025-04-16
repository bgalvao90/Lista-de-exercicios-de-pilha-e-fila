using System;
using System.Collections.Generic;

string[] expr = "3 4 + 2 *".Split();
Stack<double> pilha = new();

foreach (var t in expr)
{
    if (int.TryParse(t, out int n))
    {
        pilha.Push(n);
    }
    else
    {
        double a = pilha.Pop();
        double b = pilha.Pop();
        switch (t)
        {
            case "+":
                pilha.Push(a + b);
                break;
            case "-":
                pilha.Push(a - b);
                break;
            case "*":
                pilha.Push(a * b);
                break;
            case "/":
                pilha.Push(a / b);
                break;
        }
    }
}

Console.WriteLine($"Resultado: {pilha.Pop()}");
