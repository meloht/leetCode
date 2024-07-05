using leetCode._3051_3100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3051_3100
{
    [TestClass]
    public class _3086_MinimumMovesToPickKOnesTest
    {
        _3086_MinimumMovesToPickKOnesAlg alg = new _3086_MinimumMovesToPickKOnesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1, 0, 0, 0, 1, 1, 0, 0, 1];
            int k = 3;
            int maxChanges = 1;
            long exp = 3;
            long res = alg.MinimumMoves(nums, k, maxChanges);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [0, 0, 0, 0];
            int k = 2;
            int maxChanges = 3;
            long exp = 4;
            long res = alg.MinimumMoves(nums, k, maxChanges);
            Assert.AreEqual(exp, res);
        }
    }
}
