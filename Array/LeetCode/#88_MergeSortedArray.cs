using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _88_MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
            {
                return;
            }

            if (m == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
            }
            int k = 0;
            for (int i = m; i < nums1.Length; i++)
            {

                nums1[i] = nums2[k];
                k++;
            }

            System.Array.Sort(nums1);

            foreach (int i in nums1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
