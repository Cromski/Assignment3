using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int>[] xs = new int[][]{new []{1,2,3,4}, new int[]{3,4,5,6}};

            int[] ys;

            foreach(var item in xs.Flatten()) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
