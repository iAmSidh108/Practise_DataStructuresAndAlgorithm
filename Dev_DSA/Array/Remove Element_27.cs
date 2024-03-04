namespace Dev_DSA.Array
{
    internal class Remove_Element_27
    {
        static void Main(string[] args)
        {
            // int[] nums = [3, 2, 2, 3];

            // foreach (int i in nums)
            // {
            //     Console.WriteLine(i);
            // }

            // int num = RemoveElement(nums, 3);
            // Console.WriteLine(num);



            int RemoveElement(int[] nums)
            {
                int[] temp = null;
                int n = 0;

                for (int i = 0; i < nums.Length; i++)
                {

                    if (nums[i] == nums[i+1])
                    {
                        n++;
                        
                    }
                    else
                    {
                        temp[i] = nums[i];
                    }
                }
                return n;
                
            }
        }
    }
}
