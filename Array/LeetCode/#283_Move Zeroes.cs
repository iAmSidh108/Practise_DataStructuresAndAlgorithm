using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _283_Move_Zeroes
    {
        public int[] MoveZeroes(int[] nums)
        {

            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[k];

                    nums[k] = nums[i];
                    nums[i] = temp;
                    k++;

                }
            }

            return nums;

        }
    }
}
