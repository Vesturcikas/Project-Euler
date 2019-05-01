using System;

namespace First_50_Problems
{
    public static class Problem1
    {
        // -----
        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        // The sum of these multiples is 23.
        // Find the sum of all the multiples of 3 or 5 below 1000.
        // -----

        //Method for finding sum of all the multiples of 3 or 5 below natural number a.
        public static int SumOfDivision3and5(int a)
        {
            int result = 0;
            for (int i = 0; i < a; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
