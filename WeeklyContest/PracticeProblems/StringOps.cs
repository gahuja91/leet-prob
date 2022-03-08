using System;

namespace PracticeProblems
{
    public class StringOps
    {
        public void GetLongestSubstring(string input)
        {
            int[] characters = new int[128];
            int i = 0;
            int j = 0;
            int output = 0;
            while(j < input.Length)
            {
                if (characters[input[j]] >= 1)
                {
                    characters[input[i]]--;
                    i++;
                }
                else
                {
                    characters[input[j]]++;
                    j++;
                }

                output = Math.Max(output, j - i);
            }
            Console.WriteLine($"Longest Substring: {output}");
        }
    }
}
