using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practise.ADT
{
    public class Pokemon
    {

        static void Main(string[] args)
        {
            int[] nums = [3,3];
            Pokemon poke=new Pokemon();

            poke.TwoSum(nums,6);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] tempArr=new int[2];
            for (int i = 0; i < nums.Length; i++ )
            {
                for(int j = 1;j<nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        tempArr[0] = nums[i];
                        tempArr[1] = nums[j];
                        
                        
                    }
                    
                }
            }
            return tempArr;
        }


    }
}
