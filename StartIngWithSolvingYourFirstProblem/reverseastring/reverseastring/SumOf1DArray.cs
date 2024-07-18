namespace reverseastring
{
    internal class SumOf1DArray
    {
        public static void Main3(string[] args)
        {

            int[] nums = { 1, 2, 3, 4, 5 };
            var array = SumOf1DArrayMethod(nums);
            var output = string.Join(", ", array.Skip(1));
            Console.WriteLine("test data");
            // output = 1, 3, 6, 10, 15
        }

        public static int[] SumOf1DArrayMethod(int[] array)
        {
            var result = new int[array.Length];
            result[0] = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                result[i] = result[i - 1] + array[i];
            }
            return result;
        }
    }
}
