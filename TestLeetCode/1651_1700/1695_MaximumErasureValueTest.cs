using leetCode._1651_1700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1651_1700
{
    [TestClass]
    public class _1695_MaximumErasureValueTest
    {
        _1695_MaximumErasureValueAlg alg = new _1695_MaximumErasureValueAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 2, 4, 5, 6];
            int exp = 17;
            int res = alg.MaximumUniqueSubarray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [5, 2, 1, 2, 5, 2, 1, 2, 5];
            int exp = 8;
            int res = alg.MaximumUniqueSubarray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
