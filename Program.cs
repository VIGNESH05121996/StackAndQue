using System;

namespace StackAndQue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack And Que\n");
            LinkedListQueue queue = new LinkedListQueue();
            queue.EnQueue(56);
            queue.EnQueue(30);
            queue.EnQueue(70);
            Console.WriteLine("\n56 is added to the top and followed by 30 and 70");
            queue.Display();
            Console.ReadLine();
        }
    }
}
