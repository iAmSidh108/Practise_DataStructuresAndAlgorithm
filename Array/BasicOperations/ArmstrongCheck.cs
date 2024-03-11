using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.BasicOperations
{
    public class ArmstrongCheck
    {
        public void ArmstrongCheckFunction(int numberToCheck)
        {
            int temp = numberToCheck;
            int sum = 0;

            while (temp > 0)
            {
                int lastDigit = temp % 10;
                temp /= 10;
                sum += lastDigit * lastDigit * lastDigit;

            }

            if (sum == numberToCheck)
            {
                Console.WriteLine("This is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("This is not an Armstrong number.");
            }


        }
    }
}
