using leetCode._2151_2200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2151_2200
{
    [TestClass]
    public class _2154_KeepMultiplyingFoundValuesByTwoTest
    {
        _2154_KeepMultiplyingFoundValuesByTwoAlg alg = new _2154_KeepMultiplyingFoundValuesByTwoAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [5, 3, 6, 1, 12];
            int original = 3;
            int exp = 24;
            int res = alg.FindFinalValue(nums, original);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 7, 9];
            int original = 4;
            int exp = 4;
            int res = alg.FindFinalValue(nums, original);
            Assert.AreEqual(exp, res);
        }
    }
}
