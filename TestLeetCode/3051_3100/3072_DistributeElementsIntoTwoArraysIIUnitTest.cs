using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3072_DistributeElementsIntoTwoArraysIIUnitTest
    {
        _3072_DistributeElementsIntoTwoArraysIIAlg alg = new _3072_DistributeElementsIntoTwoArraysIIAlg();

        [TestMethod]
        public void TestCase01()
        {

            int[] nums = [2, 1, 3, 3];
            int[] exp = [2, 3, 1, 3];
            int[] res = alg.ResultArray(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [5, 14, 3, 1, 2];
            int[] exp = [5, 3, 1, 2, 14];
            int[] res = alg.ResultArray(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [3, 3, 3, 3];
            int[] exp = [3, 3, 3, 3];
            int[] res = alg.ResultArray(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
