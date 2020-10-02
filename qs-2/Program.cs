using System;
using System.Collections;

namespace qs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var queueList = new Queue<int>();
           
            queueList.Enqueue(50);
            queueList.Enqueue(10);
            queueList.Enqueue(30);
            queueList.Enqueue(10);

            queueList.Dequeue();
          

            Console.WriteLine("Peek: " + queueList.Peek());

            foreach (var item in queueList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek: " + queueList.Peek());
        }
    }
}
