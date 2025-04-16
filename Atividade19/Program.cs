using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();
        string currentAction = string.Empty;

        while (true)
        {
            Console.WriteLine("Ação atual: " + (string.IsNullOrEmpty(currentAction) ? "Nenhuma" : currentAction));
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Executar uma nova ação");
            Console.WriteLine("2. Desfazer (Undo)");
            Console.WriteLine("3. Refazer (Redo)");
            Console.WriteLine("4. Sair");
            Console.Write("Opção: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Digite a nova ação: ");
                    string newAction = Console.ReadLine();
                    if (!string.IsNullOrEmpty(currentAction))
                    {
                        undoStack.Push(currentAction);
                    }
                    currentAction = newAction;
                    redoStack.Clear(); 
                    break;

                case "2":
                    if (undoStack.Count > 0)
                    {
                        redoStack.Push(currentAction);
                        currentAction = undoStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Nada para desfazer.");
                    }
                    break;

                case "3":
                    if (redoStack.Count > 0)
                    {
                        undoStack.Push(currentAction);
                        currentAction = redoStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Nada para refazer.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}