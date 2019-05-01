using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_50_Problems
{
    class Problem4
    {
        /*
        //-----
        //A palindromic number reads the same both ways. 
        //The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3 - digit numbers.
        //-----

        int largestpalindrome = 0;
        int maxnumber1 = 0;
        int maxnumber2 = 0;
            for (int i = 100; i <= 999; i++)
            {
                int number3 = 0;
                for (int k = i; k <= 999; k++)
                {
                    number3 = i* k;
        int n6 = number3 / 100000;
        int a = (number3 - n6 * 100000);
        int n5 = a / 10000;
        int b = a - n5 * 10000;
        int n4 = b / 1000;
        int c = b - n4 * 1000;
        int n3 = c / 100;
        int d = c - n3 * 100;
        int n2 = d / 10;
        int n1 = d - n2 * 10;
                    if (n6==0)
                    {
                        if (n5==n1 && n4==n2)
                        {
                            if (largestpalindrome<number3)
                            {
                                largestpalindrome = number3;
                                maxnumber1 = i;
                                maxnumber2 = k;
                            }
}
                    }
                    else
                    {
                        if (n6==n1 && n5==n2 && n4==n3)
                        {
                            if (largestpalindrome<number3)
                            {
                            largestpalindrome = number3;
                            maxnumber1 = i;
                            maxnumber2 = k;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("The largest palindrome made from the product of two 3 - digit numbers is {0} = {1} x {2} .", largestpalindrome, maxnumber1, maxnumber2);
            */
    }
}
