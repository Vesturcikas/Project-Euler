using Microsoft.VisualStudio.TestTools.UnitTesting;
using First_50_Problems;
using System.Collections.Generic;

namespace UnitTestProjectEuler
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Problem1_ShouldReturn_233168()
        {
            Assert.AreEqual(Problem1.SumOfDivision3and5(1000), 233168);
        }

        [TestMethod]
        public void Problem2_ShuldReturn_4613732()
        {
            Assert.AreEqual(Problem2.SumOfEvenFibonacciNumbers(4000000), 4613732);
        }

        [TestMethod]
        public void Problem3_ShuldReturn_6857()
        {
            List<long> prfact = Problem3.FindPrimeNumbers(600851475143);
            Assert.AreEqual(Problem3.FindMaxNumber(prfact), 6857);
        }

        [TestMethod]
        public void Problem4_ShuldReturn_906609()
        {
            Assert.AreEqual(Problem4.FindLargestPalindrome(3), 906609);
        }

        [TestMethod]
        public void Problem6_ShuldReturn_25164150()
        {
            Assert.AreEqual(Problem6.SquereOfSumNaturalNumbers(100)-Problem6.SumOfSquaresNaturalNumbers(100), 25164150);
        }

        [TestMethod]
        public void Problem7_ShuldReturn_13()
        {
            Assert.AreEqual(Problem7.FindPrimeNumberN(6), 13);
        }
    }
}
