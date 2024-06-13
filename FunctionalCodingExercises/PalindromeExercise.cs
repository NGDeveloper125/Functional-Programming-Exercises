
using System.Runtime.InteropServices;
using System.Text;

namespace FunctionalCodingExercises;

public static class PalindromeExercise
{
    public static void IsPalindrome(string input) => 
                        Console.WriteLine(input.ToLower() == Reverse(input).ToLower());

    private static string Reverse(string input) 
    {
        var sb = new StringBuilder();
        for(int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }
        return sb.ToString();
    }
}