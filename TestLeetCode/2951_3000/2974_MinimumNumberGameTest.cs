using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2951_3000
{
    [TestClass]
    public class _2974_MinimumNumberGameTest
    {
        _2974_MinimumNumberGameAlg alg = new _2974_MinimumNumberGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [5, 4, 2, 3];
            int[] exp = [3, 2, 5, 4];
            int[] res = alg.NumberGame(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 5];
            int[] exp = [5, 2];
            int[] res = alg.NumberGame(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
