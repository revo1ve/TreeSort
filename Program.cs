using System;
using System.Collections.Generic;

namespace TreeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());

            var a = new List<string>();
            var random = new Random();
            for (int i = 0; i < n; i++)
                a.Add(random.Next(0, 100).ToString());

            Console.WriteLine("Random Array: {0}", string.Join(" ", a));

            Console.WriteLine("Sorted Array: {0}", string.Join(" ", TreeSort.GetSortedList(a)));
        }
    }
}
