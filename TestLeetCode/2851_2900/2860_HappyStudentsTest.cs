using leetCode._2851_2900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2851_2900
{
    [TestClass]
    public class _2860_HappyStudentsTest
    {
        _2860_HappyStudentsAlg alg = new _2860_HappyStudentsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 1];
            int exp = 2;
            int res = alg.CountWays(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [6, 0, 3, 3, 6, 7, 2, 7];
            int exp = 3;
            int res = alg.CountWays(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
