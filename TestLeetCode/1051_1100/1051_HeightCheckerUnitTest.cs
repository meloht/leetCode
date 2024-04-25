using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1051_HeightCheckerUnitTest
    {
        _1051_HeightCheckerAlg alg = new _1051_HeightCheckerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] heights = [1, 1, 4, 2, 1, 3];
            int exp = 3;
            int res = alg.HeightChecker(heights);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] heights = [5, 1, 2, 3, 4];
            int exp = 5;
            int res = alg.HeightChecker(heights);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] heights = [1, 2, 3, 4, 5];
            int exp = 0;
            int res = alg.HeightChecker(heights);
            Assert.AreEqual(exp, res);
        }
    }
}
