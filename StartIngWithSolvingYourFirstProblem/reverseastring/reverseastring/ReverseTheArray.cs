using Microsoft.Graph.Models.Security;

namespace reverseastring
{
    internal class ReverseTheArray
    {
        public static void ReverseTheArray1(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            for(int i = 0; i < end; i++)
            {
                int temp  = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
        }

        public static void ReverseTheArray2(int[] array)
        {
            // first take two variable 
            int start = 0, end = array.Length - 1;
            // now just try to swap the no 
            for (int i = 0; i < end; ++i)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                start++;
                end--;
            }
        }

        public static int SwapTwoNo(int a, int b)
        {
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine("after swap a: {0}", a);
            Console.WriteLine("after swap b: {0}", b);
            return b;
        }

        // Sort an array in descending order


        public static void SortArrayDescending(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortArrayAscending(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap the elements if the current element is greater than the next
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }


    }
}
