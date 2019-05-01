using System;
using System.Collections.Generic;


namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----
            //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?
            //-----

            long pNumber = 0;

            Console.WriteLine("Enter the number greater than 1.");
            Console.Write("Your number: ");
            int givennumber = Convert.ToInt32(Console.ReadLine());
            int last = givennumber;


            static List<int> primenumber(int n)
            {
                List<int> prnumb = new List<int>();
                int last = n;
                for (int i = 2; i <= last; i++)
                {
                    if (n%i==0)
                    {
                        prnumb.Add(i);
                        int ci = 1;
                        int m = last / i;
                        for (int j = i; j <= m; j++)
                        {
                            if (m%j==0)
                            {
                                ci += 1;
                                m = m / j;
                            }
                        }

                    }
                }
            }
        }
    }
}
