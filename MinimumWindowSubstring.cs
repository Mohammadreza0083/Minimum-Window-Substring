namespace Minimum_Window_Substring
{
    public class MinimumWindowSubstring : IMinimumWindowSubstring
    {
        public List<string> Substrings(int lenght, string input)
        {
            if (string.IsNullOrEmpty(input) || lenght <= 0)
                return new List<string>();

            int chunckSize = lenght + 1;
            List<string> substrings = new List<string>();

            for (int i = 0; i < input.Length - lenght + 1; i++)
            {
                if (i + chunckSize <= input.Length)
                {
                    substrings.Add(input[i..(i + lenght)]);
                    substrings.Add(input[i..(i + chunckSize)]);
                }
            }

            return substrings;
        }
        public string MinWindowSubstring(List<string> substrings, string t)
        {
            if (substrings.Count == 0 || string.IsNullOrEmpty(t))
                return "";
            List<char> Tchars = t.ToList();
            foreach (var item in substrings)
            {
                List<char> Helper = new List<char>(Tchars);
                foreach (char c in item)
                {
                    if (Helper.Contains(c))
                    {
                        Helper.Remove(c);
                    }
                    if (Helper.Count == 0)
                    {
                        return item;
                    }
                }
            }
            return "";

        }
        public string MinWindowSubstring(string s, string t)
        {
            List<string> SSubstring = Substrings(t.Length,s);
            return MinWindowSubstring(SSubstring, s);
        }
    }



}
