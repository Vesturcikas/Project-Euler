using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----
            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143 ?
            //-----

            List<long> primenumbers = new List<long>();

            Console.WriteLine("Enter the number greater than 1.");
            Console.Write("Your number: ");
            long givennumber = Convert.ToInt64(Console.ReadLine());
            var last = givennumber;

            for (long i = 2; i <= last; i++)
            {
                if (last%i==0)
                {
                    if (primenumbers==null)
                    {
                        primenumbers.Add(i);
                        last = last / i;
                        Console.WriteLine(i);
                    }
                    else
                    {
                        int sum =0;
                        for (int k = 0; k < primenumbers.Count; k++)
                        {
                            if (i%primenumbers[k]==0)
                            {
                                sum += 1;
                            }
                        }
                        if (sum==0)
                        {
                            primenumbers.Add(i);
                            last = last / i;
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            Console.WriteLine("Max: "+ primenumbers.Max());
        }
    }
}
