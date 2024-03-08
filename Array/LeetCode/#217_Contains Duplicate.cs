using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _217_Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {

            //Solution 1
            for (int i = 0; i < nums.Length; i++)
            {
                int elementToCompare = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[j] == elementToCompare)
                    {
                        return true;

                    }
                }

            }

            return false;


            ////Solution 2
            //HashSet<int> set = new HashSet<int>(nums);

            //return nums.Length != set.Count;
        }
    }
}
