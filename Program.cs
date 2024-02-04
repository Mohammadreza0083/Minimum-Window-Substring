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
            string minSub = minimumWindowSubstring.MinWindowSubstring(FirstInput, LastInput);
            Console.WriteLine(minSub);
        }
    }
}
