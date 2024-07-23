

namespace reverseastring
{
    public class reversetheorderofstring
    {
        public string ReverseTheOrderOfStrings(string inputString)
        {
            char [] str = new char[inputString.Length];
            int j = 0;
            string c = "";
            foreach (char i in inputString)
            {
                c = i + c;
            }
            return c;
        }
    }
}
