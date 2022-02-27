using System;
using System.Collections.Generic;
using System.Text;

namespace WeeklyContest
{
    //REFERENCE: https://leetcode.com/contest/weekly-contest-282/problems/minimum-number-of-steps-to-make-two-strings-anagram-ii/
    public class Anagram
    {
        public int minSteps(string s, string t)
        {
            int count = 0;
            int[] freq = new int[26];
            foreach(char c in s.ToCharArray())
                freq[c - 'a']++;

            foreach (char c in t.ToCharArray())
                freq[c - 'a']--;

            foreach (int val in freq)
                count += Math.Abs(val);

            Console.WriteLine(count);
            return count;
        }

        public void Execute()
        {
            string s = "nightttt";
            string t = "tthings";
            minSteps(s, t);
        }
    }
}
