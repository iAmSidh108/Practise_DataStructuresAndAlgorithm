using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _349_IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            //List<int> result = new List<int>();
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    for (int j = 0; j < nums2.Length; j++)
            //    {
            //        if (nums1[i] == nums2[j])
            //        {
            //            if (result.Contains(nums1[i]))
            //                break;

            //            else
            //                result.Add(nums1[i]);
            //        }


            //    }
            //}

            //return result.ToArray();


            HashSet<int> numsArry1 = new HashSet<int>(nums1);
            HashSet<int> intersectSet = new HashSet<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (numsArry1.Contains(nums2[i]))
                {
                    intersectSet.Add(nums2[i]);
                }
            }

            return intersectSet.ToArray();


        }
    }
}
