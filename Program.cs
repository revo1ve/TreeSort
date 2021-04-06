using System;
using System.Collections.Generic;

namespace TreeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input data: ");
            var input = Console.ReadLine().Split(" ");
            var data = new List<string>();
            foreach (var item in input)
                data.Add(item);
            Console.Write("Sorted data: ");
            foreach (var item in TreeSort.GetSortedList(data))
                Console.Write(item + " ");
            Console.ReadKey();
        }
    }
}
