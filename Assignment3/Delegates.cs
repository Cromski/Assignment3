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

        public delegate bool NumberEquality(string text, int number);

        public static NumberEquality NumberEqualityOperation = (text, number) => 
        {
            try 
            {
                return Int64.Parse(text.Trim()) == number;
            } 
            catch(Exception) 
            {
                return false;
            }
        };

        public delegate int BinaryOperations(int x, int y);

        public static BinaryOperations Product = (x, y) => x * y;
    }
}