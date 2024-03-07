using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class _350_IntersectionofTwoArraysII
    {

        

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        result.Add(nums1[i]);
                        nums1[i] = int.MinValue;
                        nums2[j] = int.MaxValue;
                        break;

                    }

                }
            }
            return result.ToArray();
        }
    }
}
