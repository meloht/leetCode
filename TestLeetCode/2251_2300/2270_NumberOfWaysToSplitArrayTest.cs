using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2270_NumberOfWaysToSplitArrayTest
    {
        _2270_NumberOfWaysToSplitArrayAlg alg = new _2270_NumberOfWaysToSplitArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [10, 4, -8, 7];
            int exp = 2;
            int res = alg.WaysToSplitArray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 3, 1, 0];
            int exp = 2;
            int res = alg.WaysToSplitArray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
