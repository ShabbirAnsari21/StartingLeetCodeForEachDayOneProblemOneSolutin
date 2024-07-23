using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseastring
{
    internal class ReversetheString
    {
        public static void Main2(string[] args)
        {
            string inp = "ABC";
            Console.WriteLine(inp);
            Console.WriteLine(ReverseString(inp));
        }

        public static string ReverseString(string inp)
        {
            char[] reverseString = new char[inp.Length];
            int j = 0;
            for (int i = inp.Length - 1; i >= 0; i--)
            {
                reverseString[j] = inp[i];
                j++;
            }
            return new string(reverseString);
            
            
            
        }

        public static string ReverseStringMethod(string s)
        {
            string reversed = "";
            foreach (char c in s)
            {
                reversed = c + reversed;
            }

            return reversed;
        }
    }
}
