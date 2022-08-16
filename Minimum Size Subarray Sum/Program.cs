using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Size_Subarray_Sum
{
    //https://leetcode.com/problems/minimum-size-subarray-sum/


    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 2, 3, 1, 2, 4, 3 };
            var target = 7;
            var output = MinSubArrayLen(target, input);
            Console.WriteLine(output);
            Console.Read();

        }

        public static int MinSubArrayLen(int target, int[] nums)
        {
            var left_pointer = 0;
            var total = 0;
            var result = int.MaxValue;


            for (int right_pointer = 0; right_pointer < nums.Length; right_pointer++)
            {
                total += nums[right_pointer];
                while (total >= target)
                {
                    result = Math.Min(right_pointer - left_pointer + 1, result);

                    total -= nums[left_pointer];
                    left_pointer++;
                }
            }
            return result == int.MaxValue ? 0 : result;
        }
    }
}
