using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment3
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items)
        {
            foreach (var list in items)
            {
                foreach (var element in list)
                {
                    yield return element;
                }
            }
        }

        public static bool IsSecure(this Uri uri) => (uri.Scheme == Uri.UriSchemeHttps);


        public static int WordCount(this string sentence) => (Regex.Matches(sentence, @"(?<name>\b[^\s\d]+\b)").Count);


        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var element in items)
            {
                if (predicate(element))
                    yield return element;
            }
        }
    }
}