using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _315_CountOfSmallerNumbersAfterSelfUnitTest
    {
        _315_CountOfSmallerNumbersAfterSelfAlg alg = new _315_CountOfSmallerNumbersAfterSelfAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [5, 2, 6, 1];
            int[] exp = [2, 1, 1, 0];
            int[] res = alg.CountSmaller(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-1];
            int[] exp = [0];
            int[] res = alg.CountSmaller(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [-1, -1];
            int[] exp = [0, 0];
            int[] res = alg.CountSmaller(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [0, 1, 2];
            int[] exp = [0, 0, 0];
            int[] res = alg.CountSmaller(nums).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
