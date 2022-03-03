using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class stack
    {
        public static void Main()
        {
            Stack<string> myStack = new Stack<string>();

            myStack.Push("1st element");

            myStack.Push("2st element");

            myStack.Push("3st element");

            myStack.Push("4st element");

            myStack.Push("5st element");

            Console.Write("total number of elements in the stack are:");

            Console.WriteLine(myStack.Count);
            Console.WriteLine("elements at top is:" +myStack.Peek());

            Console.Write("total number of elements in the stack are:");
            Console.WriteLine(myStack.Count);
            Console.ReadLine();





        }
    }
}
