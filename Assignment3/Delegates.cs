using System;

namespace Assignment3
{
    public static class Delegates
    {
        
        public delegate void ReverseOrder(string originalString);

        public static ReverseOrder PrintReverseString = (s) =>
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        };
            
        
    }
}