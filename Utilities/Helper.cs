using System;
using System.Collections.Generic;

namespace Utilities
{
    public static class Helper
    {
        /// Alphabetize the characters in the string. 
        public static string Alphabetize(string s)
        {

            char[] a = s.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }

        public static int GetHashCode<T>(this T value) where T : class
        {
            return value == null ? 0 : value.GetHashCode();
        }

        public static void PrintResultAnagrams(List<string> list)
        {
            if (list.Count > 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No Anagrams found in the file");
            }
        }
    }
}
