using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class StackDemo
    {
        public static void StackUses()
        {
            Stack<int> myStack = new Stack<int>();
            //Adding elements in stack
            myStack.Push(11);
            myStack.Push(35);
            myStack.Push(59);
            myStack.Push(9);

            //Printing the stack
            foreach (var item in myStack)
                Console.Write(item + ",");

            //Pop() return last added element and removeit
            myStack.Pop();
            Console.WriteLine("After pop:");
            foreach (var item in myStack)
                Console.Write(item + ",");

            //Peek() shows lastly added element
            Console.Write("Number of elements in Stack: {0}", myStack.Count);// prints 4
            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek());
                Console.WriteLine(myStack.Peek()); 
            }

            //Contains() is for searching and showing result in boolean
            Console.WriteLine(myStack.Contains(23));

            //Clear() remove all element from stack
            myStack.Clear();
        }
    }
}
