using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _697_DegreeOfAnArrayUnitTest
    {
        _697_DegreeOfAnArrayAlg alg = new _697_DegreeOfAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 2, 3, 1];
            int exp = 2;
            int res = alg.FindShortestSubArray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 2, 3, 1, 4, 2];
            int exp = 6;
            int res = alg.FindShortestSubArray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
