using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3007_MaximumNumberThatSumOfThePricesIsLessThanOrEqualToKTest
    {
        _3007_MaximumNumberThatSumOfThePricesIsLessThanOrEqualToKAlg alg = new _3007_MaximumNumberThatSumOfThePricesIsLessThanOrEqualToKAlg();

        [TestMethod]
        public void TestCase01()
        {
            int k = 9;
            int x = 1;
            long exp = 6;
            long res = alg.FindMaximumNumber(k, x);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int k = 7;
            int x = 2;
            long exp = 9;
            long res = alg.FindMaximumNumber(k, x);
            Assert.AreEqual(exp, res);
        }


    }
}
