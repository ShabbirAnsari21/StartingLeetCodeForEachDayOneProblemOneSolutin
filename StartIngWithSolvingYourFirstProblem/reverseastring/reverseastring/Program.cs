//Q.1: How to reverse a string?
//Ans.: The user will input a string and the method should return the reverse of that string

//input: hello, output: olleh
//input: hello world, output: dlrow olleh


public class Program
{
    public static void Main(string[] args)
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
    static void Main(string[] args)
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