using System.Collections.Generic;

namespace First_50_Problems
{
    public static class Problem3
    {
        //-----
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143 ?
        //-----

        public static List<long> FindPrimeNumbers(long n)
        {
            List<long> result = new List<long>();
            for (long i = 2; i <= n; i++)
            {
                if (n%i == 0)
                {
                    result.Add(i);
                    n = n / i;
                    i = i - 1;
                }
            }
            return result;
        }

        public static long FindMaxNumber(List<long> list)
        {
            long result = 0;
            foreach (var item in list)
            {
                if (item>result)
                {
                    result = item;
                }
            }
            return result;
        }




    }
}
