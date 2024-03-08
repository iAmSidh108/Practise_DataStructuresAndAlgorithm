using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _268_Missing_Number
    {
        public int MissingNumber(int[] nums)
        {

            int arraySum = 0;
            foreach (int i in nums)
                arraySum += i;

            int actualSum = (nums.Length * (nums.Length + 1)) / 2;
            return actualSum - arraySum;
        }
    }
}
