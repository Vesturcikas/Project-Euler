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
    }
}
