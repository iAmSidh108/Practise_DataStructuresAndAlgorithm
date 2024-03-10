using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.LeetCode
{
    internal class _204_CountPrimes
    {
        public int CountPrimes(int n)
        {

            if (n <= 2) return 0;

            bool[] notPrime = new bool[n];
            int num = 0;

            for (int i = 2; i < n; i++)
            {
                if (!notPrime[i])
                {
                    num++;
                    for (int j = 2; j * i < n; j++)
                        notPrime[i * j] = true;
                }
            }
            return num;


        }
    }
}
