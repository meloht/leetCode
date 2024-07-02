using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3115_MaximumPrimeDifferenceTest
    {
        _3115_MaximumPrimeDifferenceAlg alg = new _3115_MaximumPrimeDifferenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 2, 9, 5, 3];
            int exp = 3;
            int res = alg.MaximumPrimeDifference(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 8, 2, 8];
            int exp = 0;
            int res = alg.MaximumPrimeDifference(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
