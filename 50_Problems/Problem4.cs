using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_50_Problems
{
    public static class Problem4
    {
        
        //-----
        //A palindromic number reads the same both ways. 
        //The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3 - digit numbers.
        //-----

        public static int FindLargestPalindrome(int n)
        {
            int result = 0;
            int last = 1;
            switch (n)
            {
                case 3:
                    {
                        last = 999; break;
                    }
                default:
                    break;
            }
            for (int i = 100; i <= last; i++)
            {
                int number3 = 0;
                for (int k = i; k <= last; k++)
                {
                    number3 = i * k;
                    if (Problem4.ItPalindromicNumber(number3))
                    {
                        if (number3 > result)
                        {
                            result = number3;
                        }
                    }
                }
            }
            return result;
        }

        public static bool ItPalindromicNumber(int n)
        {
            bool result = false;
            int n6 = n / 100000;
            int n5 = (n - n6 * 100000) / 10000;
            int n4 = ((n - n6 * 100000) - n5 * 10000) / 1000;
            int n3 = ((n - n6 * 100000) - n5 * 10000 - n4 * 1000) / 100;
            int n2 = ((n - n6 * 100000) - n5 * 10000 - n4 * 1000 - n3 * 100) / 10;
            int n1 = n - n6 * 100000 - n5 * 10000 - n4 * 1000 - n3 * 100 - n2 * 10;
            if (n6 == 0)
            {
                if (n5 == n1 && n4 == n2)
                {
                    result = true;
                }
            }
            else
            {
                if (n6 == n1 && n5 == n2 && n4 == n3)
                {
                    result = true;
                }
            }
            return result;
        }

    }
}
