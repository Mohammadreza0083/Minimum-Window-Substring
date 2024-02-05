namespace Minimum_Window_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MinimumWindowSubstring minimumWindowSubstring = new();
            Console.WriteLine("Entre your first string : ");
            string FirstInput = Console.ReadLine();
            Console.WriteLine("Enter your second string : ");
            string LastInput = Console.ReadLine();
            string result =minimumWindowSubstring.MinWindowSubstring(FirstInput, LastInput);
            Console.WriteLine($"Minimum window substring of {FirstInput} and {LastInput} is : {result}");
        }
    }
}
