using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_50_Problems
{
    public static class Problem6
    {
        //-----
        //The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... +10^2 = 385
        //The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 552 = 3025
        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 
        //3025 − 385 = 2640.
        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        //-----

        public static int SquereOfSumNaturalNumbers (int n)
        {
            int result = 0;
            int sum = n*(n+1)/2;
            return result = sum * sum;
        }

        public static int SumOfSquaresNaturalNumbers (int n)
        {
            int result2 = 0;
            for (int i = 1; i <= n; i++)
            {
                result2 += (int)Math.Pow(i, 2);
            }
            return result2;
        }
    }
}
