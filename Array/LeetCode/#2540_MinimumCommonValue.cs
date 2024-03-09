using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _2540_MinimumCommonValue
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j]) return nums1[i];
                    else if (nums1[i] < nums2[j]) break;
                }
            }

            //int i = 0; int j = 0;
            //while (i < nums1.Length && j<nums2.Length)
            //{
            //    if (nums1[i] == nums2[j])
            //    {
            //        return nums1[i];
            //    }
            //    else if (nums1[i] < nums2[j])
            //    {
            //        i++;
            //    }
            //    else if (nums1[i]> nums2[j])
            //    {
            //        j++;
            //    }
            //}

            return -1;
        }
    }
}
