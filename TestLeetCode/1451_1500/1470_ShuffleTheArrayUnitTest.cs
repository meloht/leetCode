using leetCode._1451_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._1451_1500
{
    [TestClass]
    public class _1470_ShuffleTheArrayUnitTest
    {
        _1470_ShuffleTheArrayAlg alg = new _1470_ShuffleTheArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 5, 1, 3, 4, 7];
            int n = 3;
            int[] exp = [2, 3, 5, 4, 1, 7];
            int[] res = alg.Shuffle(nums, n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 4, 3, 2, 1];
            int n = 4;
            int[] exp = [1, 4, 2, 3, 3, 2, 4, 1];
            int[] res = alg.Shuffle(nums, n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 1, 2, 2];
            int n = 2;
            int[] exp = [1, 2, 1, 2];
            int[] res = alg.Shuffle(nums, n);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
