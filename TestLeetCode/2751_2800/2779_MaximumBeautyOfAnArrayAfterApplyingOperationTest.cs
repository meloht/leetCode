using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2751_2800
{
    [TestClass]
    public class _2779_MaximumBeautyOfAnArrayAfterApplyingOperationTest
    {
        _2779_MaximumBeautyOfAnArrayAfterApplyingOperationAlg alg = new _2779_MaximumBeautyOfAnArrayAfterApplyingOperationAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [4, 6, 1, 2];
            int k = 2;
            int exp = 3;
            int res=alg.MaximumBeauty(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 1, 1];
            int k = 10;
            int exp = 4;
            int res = alg.MaximumBeauty(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [13, 46, 71];
            int k = 29;
            int exp = 3;
            int res = alg.MaximumBeauty(nums, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [1];
            int k = 1;
            int exp = 1;
            int res = alg.MaximumBeauty(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
