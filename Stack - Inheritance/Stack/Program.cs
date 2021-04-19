using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            //stack.Pop(); handling null refference exception

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            //stack.Clear(); handling negative indexes for list

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();

            Console.ReadLine();
        }
    }
}
