namespace Array.BasicOperations
{
    public class PalindromeCheck
    {
        public void PalindromeCheckFunction(int numToCheck)
        {

            int temp = numToCheck;
            int reverse = 0;

            while (temp > 0)
            {
                int lastDigit = temp % 10;
                reverse = reverse * 10 + lastDigit;
                temp /= 10;
            }

            if (reverse == numToCheck)
            {
                Console.WriteLine("This is a palindrome number.");
            }
            else
            {
                Console.WriteLine("This is not a palindrome number.");
            }

        }
    }
}
