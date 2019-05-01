using System;
using System.Collections.Generic;


namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----
            //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            //What is the 10 001st prime number ?
            //-----

            Console.WriteLine("What is the 10 001st prime number?");
            int n = 2;
            int counter = 1;
            List<long> primenambers = new List<long>();
            primenambers.Add(n);
            //Console.WriteLine("{0} - {1};", counter, n);
            while (counter < 10001)
            {
                n += 1;
                bool signal = false;
                foreach (var item in primenambers)
                {
                    if (n%item==0) 
                    {
                        signal = true;
                        break;
                    }
                }
                if (!signal)
                {
                    primenambers.Add(n);
                    counter += 1;
                    //Console.WriteLine("{0} - {1};", counter, n);
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} - {1};", counter, n);
        }
    }
}
