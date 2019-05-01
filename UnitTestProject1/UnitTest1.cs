using Microsoft.VisualStudio.TestTools.UnitTesting;
using First_50_Problems;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Problem1_ShouldReturn_233168()
        {
            Assert.AreEqual(Problem1.SumOfDivision3and5(1000), 233168);
        }

        [TestMethod]
        public void Problem2_ShuldRetrun_4613732()
        {
            Assert.AreEqual(Problem2.SumOfEvenFibonacciNumbers(4000000), 4613732);
        }
    }
}
