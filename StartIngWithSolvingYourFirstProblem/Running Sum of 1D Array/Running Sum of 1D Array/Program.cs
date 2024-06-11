
// just imagine we have a array [2, 3, 4, 5, 6, 8]
// output [2, 5, 9, 14, 20, 28]

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 3, 4, 5, 6, 8 };
        int[] response = RunningSum(nums);

        foreach (int num in response)
        {
            Console.WriteLine(num);
        }
        Console.ReadLine();
    }

    static int[] RunningSum(int[] nums)
    {
        int[] result = new int[nums.Length];
        result[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = nums[i] + result[i - 1];
        }

        return result;
    }
}
