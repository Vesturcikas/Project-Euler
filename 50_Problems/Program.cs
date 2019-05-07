using First_50_Problems;
using System;
using System.Collections.Generic;

namespace First_50_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of problem.");
            Console.Write("Problem number: ");
            int problemNumber = Convert.ToInt32(Console.ReadLine());

            switch (problemNumber)
            {
                case 1:
                    {
                        Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
                        Console.WriteLine();
                        Console.WriteLine("Enter the number between 1 and 1000.");
                        Console.Write("Yuor number: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The Sum of all the multiples of 3 or 5 below {0}: {1}.", a, Problem1.SumOfDivision3and5(a));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");
                        Console.WriteLine();
                        Console.WriteLine("Enter the number greater than 2.");
                        Console.Write("Yuor number: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The sum of the even-valued Fibonacci nambers below {0}: {1}.", a, Problem2.SumOfEvenFibonacciNumbers(a));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("What is the largest prime factor of the number n ?");
                        Console.WriteLine();
                        Console.WriteLine("Enter the number greater than 2.");
                        Console.Write("Yuor number: ");
                        long a = Convert.ToInt64(Console.ReadLine());
                        List<long> PrameFactors = new List<long>();
                        PrameFactors = Problem3.FindPrimeNumbers(a);
                        Console.WriteLine("The primes factors of the number {0}:", a);
                        Console.WriteLine();
                        int lenght = PrameFactors.Count;
                        if (lenght == 1)
                        {
                            Console.WriteLine("{0}", PrameFactors[0]);
                        }
                        else
                        {
                            for (int i = 0; i < lenght; i++)
                            {

                                if (i == 0)
                                {
                                    Console.Write("{0}, ", PrameFactors[i]);
                                }
                                else if (i == (lenght - 1))
                                {
                                    Console.WriteLine("{0}.", PrameFactors[i]);
                                }
                                else
                                {
                                    Console.Write("{0}, ", PrameFactors[i]);
                                }
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("The largest prime factor of the number {0}: {1}.", 
                            a, Problem3.FindMaxNumber(PrameFactors));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Find the largest palindrome made from the product of two 3 - digit numbers.");
                        Console.WriteLine();
                        Console.WriteLine("Enter the number 3.");
                        Console.Write("Yuor number: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int largestpalindrome = Problem4.FindLargestPalindrome(n);
                        Console.WriteLine("The largest palindrome made from the product of two 3 - digit numbers is {0}.", largestpalindrome);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");
                        Console.WriteLine();
                        Console.WriteLine("Enter the number greater than 1.");
                        Console.Write("Yuor number: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum: {0}.", 
                            Problem6.SquereOfSumNaturalNumbers(n)-Problem6.SumOfSquaresNaturalNumbers(n));
                        break;
                    }

                default:
                    break;
            }
        }

    }
}
