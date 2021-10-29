using System;

namespace StackAndQue
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Welcome To Stack And Que\n");
            LinkedListStack stack = new LinkedListStack();
            stack.Add(70);
            stack.Add(30);
            stack.Add(56);
            Console.WriteLine("\nPushed 56 on top of the stack");
            stack.Display();
            Console.WriteLine("\nPeek and Pop Still Stack Is Empty Operation Is Done");
            stack.IsEmpty();
            Console.ReadLine();
        }
    }
}
