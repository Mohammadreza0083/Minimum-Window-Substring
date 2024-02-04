using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Window_Substring
{
    public class MinimumWindowSubstring : IMinimumWindowSubstring
    {
        public List<string> Substrings(int lenght, string input)
        {
            int chunckSize = lenght + 1;
            List<string> substrings = new List<string>();
            for (int i = 0; i < lenght; i++)
            {
                substrings.Add(input[i..(i + lenght)]);
            }
            for (int i = 0; i < chunckSize; i++)
            {
                substrings.Add(input[i..(i + chunckSize)]);
            }
            return substrings;
        }
       
        public string MinWindowSubstring(List<string> substrings)
        {
            throw new NotImplementedException();
        }

    }
}
