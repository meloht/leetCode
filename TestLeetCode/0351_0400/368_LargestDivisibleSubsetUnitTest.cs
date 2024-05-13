using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _368_LargestDivisibleSubsetUnitTest
    {
        _368_LargestDivisibleSubsetAlg alg = new _368_LargestDivisibleSubsetAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            int[] exp = [1, 2];
            int[] res = alg.LargestDivisibleSubset(nums).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 4, 8];
            int[] exp = [1, 2, 4, 8];
            int[] res = alg.LargestDivisibleSubset(nums).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [5, 9, 18, 54, 108, 540, 90, 180, 360, 720];
            int[] exp = [9, 18, 90, 180, 360, 720];
            int[] res = alg.LargestDivisibleSubset(nums).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }

}
