using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2275_LargestCombinationWithBitwiseAndGreaterThanZeroTest
    {
        _2275_LargestCombinationWithBitwiseAndGreaterThanZeroAlg alg = new _2275_LargestCombinationWithBitwiseAndGreaterThanZeroAlg();

        [TestMethod]
        public void TestCase01()
        {

            int[] candidates = [16, 17, 71, 62, 12, 24, 14];
            int exp = 4;
            int res = alg.LargestCombination(candidates);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] candidates = [8, 8];
            int exp = 2;
            int res = alg.LargestCombination(candidates);
            Assert.AreEqual(exp, res);
        }
    }
}
