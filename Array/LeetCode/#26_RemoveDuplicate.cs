using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _26_RemoveDuplicate
    {
        public int RemoveDuplicates(int[] nums)
        {
            int uniqueNumIndex = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[uniqueNumIndex] = nums[i];
                    uniqueNumIndex++;
                }
            }
            return uniqueNumIndex;
        }
    }
}
