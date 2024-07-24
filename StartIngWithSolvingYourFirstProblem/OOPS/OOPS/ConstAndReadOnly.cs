using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class ConstAndReadOnly
    {
        public const string test = "test";

        public static void Main3(string[] args)
        {
            Console.WriteLine(test);
        }
    }

    public class ReadOnly
    {
        private readonly string Data = "test";

        public ReadOnly(string data)
        {
            Data = data;
        }

        public static void Main8(string[] args)
        {
            
            //Console.WriteLine(ReadOnly(Data));
        }
    }


    public class StringVSStringBuilder
    {
        static void Main(string[] args)
        {
            string str1 = "test";
            string str2 = "test2";

            string tds = null;

            str1 = str1 + str2;
            Console.WriteLine(str1);

            StringBuilder str3 = new StringBuilder("test 3");
            str3.Append("test4");
            Console.WriteLine(str3);
        }
    }
}
