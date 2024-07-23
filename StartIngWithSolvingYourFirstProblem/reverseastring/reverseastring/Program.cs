//Q.1: How to reverse a string?
//Ans.: The user will input a string and the method should return the reverse of that string

//input: hello, output: olleh
//input: hello world, output: dlrow olleh


using reverseastring;

public class Program
{
    // this is my main method call all the other methods from here of any class
    #region

    public static void Main(string[] args)
    {
        string input = "My Name Is Shabbir";
        reversetheorderofstring obj = new reversetheorderofstring();

        Console.WriteLine(obj.ReverseTheOrderOfStrings(input));

        Console.WriteLine(input);
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(array);

        //ReverseTheArray.ReverseTheArray1(array);
        Console.WriteLine(string.Join(", ", array));

        int[] array2 = { 1, 2, 5, 9, 11, 7, 6, 8, 13, 10, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        //ReverseTheArray.SwapTwoNo(5, 10);
        ReverseTheArray.SortArrayAscending(array2);
        //ReverseTheArray.SortArrayDescending(array2);
        Console.WriteLine(string.Join(", ", array2));
    }
    #endregion




    public static void Main1(string[] args)
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

}



// check if given string is palidrome or not 

public class Palidrom
{
    static void Main2(string[] args)
    {
        string input = "step on no pets";
        Console.WriteLine(input);
        Console.WriteLine(checkPalidrome(input));


    }
    public static bool checkPalidrome(string input)
    {
        char[] str = new char[input.Length];
        int i = 0;
        for(int j = str.Length -1; j >= 0; j--) {
            str[i] = input[j];
            i++;
        }
        var str2 = new string(str);
        if(str2 == input)
        {
            return true;
        }
        return false;
        //if()
    }
}