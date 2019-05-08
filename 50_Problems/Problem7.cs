using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_50_Problems
{
    public static class Problem7
    {
        
        //-----
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number ?
        //-----

        public static long FindPrimeNumberN(int n)
        {
            long result = 0;
            int a = 2;
            int counter = 1;
            List<long> listofprimenambers = new List<long>();
            listofprimenambers.Add(a);
            while (counter < n)
            {
                a += 1;
                bool signal = false;
                foreach (var item in listofprimenambers)
                {
                    if (a % item == 0)
                    {
                        signal = true;
                        break;
                    }
                }
                if (!signal)
                {
                    listofprimenambers.Add(a);
                    counter += 1;
                    //Console.WriteLine("{0} - {1}", counter, a);
                }
            }
            return result = listofprimenambers[n - 1];
        }
    }
}
