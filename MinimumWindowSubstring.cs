namespace Minimum_Window_Substring
{
    public class MinimumWindowSubstring : IMinimumWindowSubstring
    {
        public string MinWindowSubstring(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
                return "";

            var tChars = new Queue<char>(t);
            int required = tChars.Count;
            int minStart = 0, minEnd = int.MaxValue;

            for (int start = 0, end = 0; end < s.Length; end++)
            {
                var c = s[end];
                if (tChars.Contains(c))
                {
                    tChars.Dequeue();
                    required--;
                }

                while (required == 0)
                {
                    if (end - start < minEnd - minStart)
                    {
                        minStart = start;
                        minEnd = end;
                    }

                    var firstChar = s[start];
                    start++;

                    if (tChars.Contains(firstChar))
                    {
                        tChars.Enqueue(firstChar);
                        required++;
                    }
                }
            }

            return minEnd == int.MaxValue ? "" : s.Substring(minStart, minEnd - minStart + 1);
        }


    }
}
