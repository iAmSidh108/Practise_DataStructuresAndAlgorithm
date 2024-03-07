using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class _66_PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            /*var result = new List<int>();

            var carry = 1;
            var value = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                value = digits[i] + carry;
                if (value == 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }

                result.Insert(0, value % 10);
            }

            if (carry >= 1)
                result.Insert(0, carry);

            return result.ToArray();

            */

            for (int i = digits.Length-1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            System.Array.Resize(ref digits, digits.Length+1);
            digits[0] = 1;
            return digits;

        }
    }
}
