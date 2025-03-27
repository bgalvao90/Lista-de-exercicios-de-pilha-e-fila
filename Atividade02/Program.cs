using System.Collections;
using System.Collections.Generic;

Queue<string> queue = new Queue<string>();

queue.Enqueue("Ana");
queue.Enqueue("Carlos");
queue.Enqueue("Beatriz");
queue.Enqueue("Daniel");

Console.WriteLine(queue.Peek());



Console.WriteLine("Nome removido: "+ queue.Dequeue());

Console.WriteLine("------------------------");


foreach (var item in queue)
{
    Console.WriteLine(item);
}