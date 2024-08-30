using leetCode._3151_4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_4000
{
    [TestClass]
    public class _3153_SumOfDigitDifferencesOfAllPairsTest
    {
        _3153_SumOfDigitDifferencesOfAllPairsAlg alg = new _3153_SumOfDigitDifferencesOfAllPairsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [13, 23, 12];
            long exp = 4;
            long res = alg.SumDigitDifferences(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [10, 10, 10, 10];
            long exp = 0;
            long res = alg.SumDigitDifferences(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
