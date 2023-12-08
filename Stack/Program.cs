using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            stack.Push("Birinchi element");
            stack.Push("Ikkinchi element");
            stack.Push("Uchinchi element");
            stack.Push("To'rtinchi element");
            var element = stack.Peek();  //To'rtinchi element
            Console.WriteLine(element);

            Console.WriteLine(new string('-', 20));

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadKey();
        }
    }
}
