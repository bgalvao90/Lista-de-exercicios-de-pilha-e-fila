using System.Collections.Generic;

Stack<int> stack = new Stack<int>();


stack.Push(int.Parse(Console.ReadLine()));
stack.Push(int.Parse(Console.ReadLine()));
stack.Push(int.Parse(Console.ReadLine()));
stack.Push(int.Parse(Console.ReadLine()));
stack.Push(int.Parse(Console.ReadLine()));


Console.WriteLine("-----------------------------");
foreach (var item in stack)
{
    Console.WriteLine(item);
}