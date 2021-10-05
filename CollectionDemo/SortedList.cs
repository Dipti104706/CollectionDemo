using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class SortedListDemo
    {
        public static void SortedListUses()
        {
            SortedList<int, string> number = new SortedList<int, string>();
            number.Add(3, "Three");
            number.Add(1, "One");
            number.Add(2, "Two");
            number.Add(4, null);
            number.Add(10, "Ten");
            number.Add(5, "Five");
            //Printing elements in SortedList
            foreach (var item in number)
                Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);

            //Adding elements in Sortedlist using collection initializer
            SortedList<int, string> names = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");
            foreach (KeyValuePair<int, string> item in names)
                Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
            names.Add(6, "Six");
            names.Add(2, "Two");
            names.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var item in names)
                Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);

            //Get value from sortedLIst using index
            Console.WriteLine(names[1]);

            //Remove() to remove element from sortedlist
            names.Remove(1);

            //Contains()
            Console.WriteLine(names.ContainsKey(6));

            //TryGetValue
            string res;
            Console.WriteLine(names.TryGetValue(2, out res));
            Console.WriteLine("Key: {0}, Value: {1}", 2, res);
        }
    }
}
