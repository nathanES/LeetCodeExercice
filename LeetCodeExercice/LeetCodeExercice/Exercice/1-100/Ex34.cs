using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeExercice.Exercice._1_100
{
    public class Ex34
    {
        public Ex34()
        {
//Example 1:
//Input: nums = [5, 7, 7, 8, 8, 10], target = 8
//Output: [3,4]

//Example 2:
//Input: nums = [5, 7, 7, 8, 8, 10], target = 6
//Output: [-1,-1]

//Example 3:
//Input: nums = [], target = 0
//Output: [-1,-1]
            var e1 = SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);
            var e2 = SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 6);
            var e3 = SearchRange(new int[] { }, 0);

        }
        public int[] SearchRange(int[] nums, int target)
        {
            int first = -1; // Initialize first occurrence to -1
            int last = -1;  // Initialize last occurrence to -1

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    if (first == -1)
                    {
                        first = i; // Found the first occurrence
                    }
                    last = i; // Update last occurrence
                }
            }

            // Return the result as an array
            return new int[] { first, last };
        }
    }
}
