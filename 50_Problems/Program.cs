using First_50_Problems;
using System;

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

                default:
                    break;
            }



        }

    }
}
