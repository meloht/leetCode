using leetCode._3151_4000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_4000
{
    [TestClass]
    public class _3152_SpecialArrayIITest
    {
        _3152_SpecialArrayIIAlg alg = new _3152_SpecialArrayIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [3, 4, 1, 2, 6];
            int[][] queries = [[0, 4]];
            bool[] exp = [false];
            bool[] res = alg.IsArraySpecial(nums, queries);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [4, 3, 1, 6];
            int[][] queries = [[0, 2], [2, 3]];
            bool[] exp = [false, true];
            bool[] res = alg.IsArraySpecial(nums, queries);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 2];
            int[][] queries = [[0, 0]];
            bool[] exp = [true];
            bool[] res = alg.IsArraySpecial(nums, queries);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
