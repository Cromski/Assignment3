using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int>[] xs = new int[][]{new []{1,2,3,4}, new []{3,4,5,6}};

            int[] ys = {1,3,5,6,6,7,8,8,14,2342,55};

            foreach(var item in xs.Flatten()) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("yep");
            foreach (var element in ys.Filter((x) => x % 7 == 0 && x > 42))
            {
                Console.WriteLine(element);
            }

            ys = new [] {44, 400, 100, 1700, 1800, 1000, 1600, 2000};
            Console.WriteLine("yep");
            foreach (var element in  ys.Filter((x) => x % 4 == 0 && (x % 100 != 0 || x % 400 == 0)))
            {
                Console.WriteLine(element);
            }
            ys.Filter((x) => x % 7 == 0 || x > 42);

            ys.Filter((x) => x % 4 == 0 && (x % 100 != 0 || x % 400 == 0));

        }
        
    }
}
