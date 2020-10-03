using System;
using System.Collections;

namespace pr_04_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.Enqueue("First");
            myQ.Enqueue("Second");
            myQ.Enqueue("Third");
            myQ.Enqueue("Fourth");

            while (myQ.Count > 0)
            {
                object obj = myQ.Dequeue();
                Console.WriteLine("Frome myQ: {0}", obj);
            }
            
            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
            }
        }
    }
}