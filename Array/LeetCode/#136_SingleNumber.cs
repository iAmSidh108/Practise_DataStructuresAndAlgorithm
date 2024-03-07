using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _136_SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            var a = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                a ^= nums[i];
            }
            return a;
        }
    }
}
