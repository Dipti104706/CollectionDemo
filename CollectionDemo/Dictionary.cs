using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class DictionaryDemo
    {
        public static void DictionaryUses()
        {
            Dictionary<int, string> number = new Dictionary<int, string>();
            //adding a key/value using the Add() method
            number.Add(1, "One");
            number.Add(2, "Two");
            number.Add(3, "Three");

            //Printing the elements in dictuonary
            foreach (KeyValuePair<int, string> item in number)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

            //Access values using key in the dictionary
            Console.WriteLine(number[1]);

            //use ContainsKey() to check for an unknown key
            var list = new Dictionary<string, string>(){
                            {"one", "London, Manchester, Birmingham"},
                            {"two", "Chicago, New York, Washington"},
                            {"three", "Mumbai, New Delhi, Pune"}
                         };
            list.ContainsKey("one");

            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",list.ElementAt(i).Key,list.ElementAt(i).Value);
            }
        }
    }
}
