using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_DSA.Array
{
    internal class Leet_TwoSum
    {
        static void Main(string[] args)
        {
            int[] nums = [3, 3];
            Leet_TwoSum poke = new Leet_TwoSum();

            int[] show = poke.TwoSum(nums, 6);

            foreach (int i in show)
            {
                Console.WriteLine(i);
            }
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }
            }
            return null;
        }
    }
}
