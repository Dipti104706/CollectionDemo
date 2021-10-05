using System;
using System.Collections.Generic;
using System.Collections;

namespace CollectionDemo
{
    class HashTableDemo
    {
        public static void Hashtableuses()
        {
            Hashtable numberNames = new Hashtable();
            //adding a key/value using the Add() method
            numberNames.Add(1, "One"); 
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //Printing the elements in dictuonary
            foreach (KeyValuePair<int, string> item in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

            //removing an element from hashtable
            numberNames.Remove("One");

            //checking a element present or not
            numberNames.ContainsKey(1);

            //adding a dictionary in a hashtable
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "pig");
            dict.Add(2, "bat");
            dict.Add(3, "lion");
            Hashtable hashtable = new Hashtable(dict);

            //Remove all elements
            numberNames.Clear();
        }
    }
}
