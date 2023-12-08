using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            queue.Enqueue("Birinchi element");
            queue.Enqueue("Ikkinchi element");
            queue.Enqueue("Uchinchi element");
            queue.Enqueue("To'rtinchi element");

            var element = queue.Peek();  //Birinchi element
            Console.WriteLine(element);

            Console.WriteLine(new string('-', 20));

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ReadKey();

        }
    }
}
