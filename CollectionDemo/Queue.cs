using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class QueueDemo
    {
        public static void QueueUses()
        {
            Queue<int> queue = new Queue<int>();
            //Adding elements to the queue 
            queue.Enqueue(56);
            queue.Enqueue(24);
            queue.Enqueue(63);
            queue.Enqueue(94);

            //Prints the queue
            foreach (var id in queue)
                Console.Write(id + ", ");

            //Count() 
            Console.WriteLine("\n Number of elements in the queue:");
            Console.WriteLine(queue.Count());

            //Peek() returns first elememts from queue
            Console.WriteLine(queue.Peek());

            //Contains() returns a elements present or not
            Console.WriteLine(queue.Contains(65));

            //Dequeue to remove elemts from the first
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count());
        }
    }
}
