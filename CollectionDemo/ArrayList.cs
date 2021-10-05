using System;
using System.Collections;

namespace CollectionDemo
{
    class ArrayListDemo
    {
        public void ArrayListUses()
        {
            ArrayList array = new ArrayList();

            //Adding elements to arraylist
            array.Add(1);
            array.Add(123);
            array.Add("Smile");
            array.Add(8.52);

            //Adding elements to arraylist using collection initializer
            var array2 = new ArrayList()
                {
                    2, "System", " ", 4.5, null
                };

            //Adding whole array or arraylist in present arraylist using Addrange()
            int[] array1 = { 100, 200, 300, 400 };
            var array3 = new ArrayList();
            array3.AddRange(array1);
            array3.AddRange(array2);

            //using var keyword without explicit casting
            var firstElement = array[0]; 
            var secondElement = array[1]; 

            //update elements
            array[0] = "Please";
            array[1] = 100;

            //Print arraylist elements
            foreach(var element in array)
            {
                Console.WriteLine(", ",element);
            }

            //Printing array3
            foreach (var item in array3)
                Console.Write(item + ", ");

            //Insert() use to add a elemeant at specific index position
            array.Insert(1, "Second Item");
            //Print updated array
            Console.WriteLine("\n After insertion the array becomes ");
            foreach (var item in array3)
                Console.Write(item + ", ");

            //InsertRange() used to add new list at a specific index
            array.InsertRange(2, array1);
            //Print updated array
            Console.WriteLine("\n After insertion the array becomes ");
            foreach (var item in array3)
                Console.Write(item + ", ");

            //Remove operations in arraylist
            array.Remove(1);
            array.RemoveAt(4);//RemoveAt() used for removing element at perticular index
            array2.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            //Print updated array
            Console.WriteLine("\n After removing the array becomes ");
            foreach (var item in array)
                Console.Write(item + ", ");
            foreach (var item in array2)
                Console.Write(item + ", ");

            //Contains() shows element present or not in true / false format
            var array4 = new ArrayList()
                {
                    2, "System", " ", 4.5, 5
                };
            Console.WriteLine("\n Array4 contains 2 or not");
            Console.WriteLine(array4.Contains(2));

            //Clear() use to clear all element in array list
            array4.Clear();

            //Sorting elemnts in array list
            var array5 = new ArrayList() { 56, 13, 879, 3, 587 };
            array5.Sort();
            Console.WriteLine("\n After sorting the array:");
            foreach (var item in array5)
                Console.Write(item + ", ");

            //Reverse() reverses the entire array
            array5.Reverse();
            Console.WriteLine("\n After reversing the array:");
            foreach (var item in array5)
                Console.Write(item + ", ");

            //Indexof() Search specified element and returns zero based index if found. Returns -1 if element not found
            Console.WriteLine( array5.IndexOf(2));

            //GetRange() Returns specified number of elements from specified index from ArrayList.
            Console.WriteLine(array5.GetRange(1, 2));
            //CopyTo() copy all content in a array
            int[] arr = { 1, 2, 3 };
            array5.CopyTo(arr);
        }
    }
}
