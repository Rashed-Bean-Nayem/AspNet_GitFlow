using System;
using System.Collections;

namespace SortedListExamQs_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList NumberSortedList = new SortedList();
           
            NumberSortedList.Add(4, "Four");
            NumberSortedList.Add(1, "One");
            NumberSortedList.Add(3, "Three");
            NumberSortedList.Add(7, "Seven");
           
          
          
            foreach (var item in NumberSortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}
