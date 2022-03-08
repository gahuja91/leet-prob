using System;
using System.Linq;

namespace WeeklyContest
{
    //REFERENCE: https://leetcode.com/contest/weekly-contest-283/problems/append-k-integers-with-minimal-sum/
    public class _2195MinimalSum
    {
        public long MinimalKSum(int[] nums, int k)
        {
            var sum = (1L * k * (k + 1)) / 2;
            Array.Sort(nums);
            //foreach (var num in nums)
            //{
            //    if (num <= k)
            //    {
            //        sum = sum - num;
            //        sum = sum + ++k;
            //    }
            //}
            for (int i = 0; i < nums.Count(); i++)
            {
                sum += nums[i] <= k && (i == 0 || nums[i] != nums[i - 1]) ? ++k - nums[i] : 0;
            }
            Console.WriteLine($"Sum: {sum}");
            return sum;
        }

        public void Execute()
        {
            MinimalKSum(new int[] {5, 5}, 6);
        }
    }
}
