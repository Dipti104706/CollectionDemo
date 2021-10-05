using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the collection operation you want");
            Console.WriteLine("Enter 1 for ArrayList");
            Console.WriteLine("Enter 2 for stack");
            Console.WriteLine("Enter 3 for queue");
            Console.WriteLine("Enter 4 for SortedList");
            Console.WriteLine("Enter 5 for HashSet");
            Console.WriteLine("Enter 6 for Dictionary");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ArrayListDemo arrayList = new ArrayListDemo();
                    arrayList.ArrayListUses();
                    Console.ReadLine();
                    break;
                case 2:
                    StackDemo.StackUses();
                    Console.ReadLine();
                    break;
                case 3:
                    QueueDemo.QueueUses();
                    Console.ReadLine();
                    break;
                case 4:
                    SortedListDemo.SortedListUses();
                    Console.ReadLine();
                    break;
                case 5:
                    HashTableDemo.Hashtableuses();
                    Console.ReadLine();
                    break;
                case 6:
                    DictionaryDemo.DictionaryUses();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter valid input");
                    break;
            }
        }
    }
}
