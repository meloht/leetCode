using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _493_ReversePairsTest
    {
        _493_ReversePairsAlg alg = new _493_ReversePairsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 2, 3, 1];
            int exp = 2;
            int res = alg.ReversePairs(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 4, 3, 5, 1];
            int exp = 3;
            int res = alg.ReversePairs(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
