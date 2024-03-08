using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }

                if (dict[nums[i]] > nums.Length / 2)
                    return nums[i];
            }

            return -1;
        }
    }
}
