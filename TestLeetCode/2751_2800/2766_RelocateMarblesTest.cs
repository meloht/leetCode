using leetCode._2751_2800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2751_2800
{
    [TestClass]
    public class _2766_RelocateMarblesTest
    {
        _2766_RelocateMarblesAlg alg = new _2766_RelocateMarblesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 6, 7, 8], moveFrom = [1, 7, 2], moveTo = [2, 9, 5];
            int[] exp = [5, 6, 8, 9];
            int[] res = alg.RelocateMarbles(nums, moveFrom, moveTo).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 3, 3], moveFrom = [1, 3], moveTo = [2, 2];
            int[] exp = [2];
            int[] res = alg.RelocateMarbles(nums, moveFrom, moveTo).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
