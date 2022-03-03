using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class queue
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(25);
            myQueue.Enqueue(35);
            myQueue.Enqueue(45);
            myQueue.Enqueue(55);
            myQueue.Enqueue(65);

            Console.Write("total number of elements in the queue are:");

            Console.WriteLine(myQueue.Count);
            Console.ReadLine();

        }
    }
}
