using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _659_SplitArrayIntoConsecutiveSubsequencesTest
    {
        _659_SplitArrayIntoConsecutiveSubsequencesAlg alg = new _659_SplitArrayIntoConsecutiveSubsequencesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 3, 4, 5];
            bool exp = true;
            bool res = alg.IsPossible(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 3, 4, 4, 5, 5];
            bool exp = true;
            bool res = alg.IsPossible(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3, 4, 4, 5];
            bool exp = false;
            bool res = alg.IsPossible(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [1];
            bool exp = false;
            bool res = alg.IsPossible(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
