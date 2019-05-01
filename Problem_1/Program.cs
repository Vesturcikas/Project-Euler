using System;


namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
            // The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.
            // -----

            var Sum = 0;
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine("Sum of all the multiples of 3 or 5 below 1000: {0}", Sum);
        }
    }
}
