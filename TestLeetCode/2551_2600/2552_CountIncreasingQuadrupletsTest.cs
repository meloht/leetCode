using leetCode._2551_2600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2551_2600
{
    [TestClass]
    public class _2552_CountIncreasingQuadrupletsTest
    {
        _2552_CountIncreasingQuadrupletsAlg alg = new _2552_CountIncreasingQuadrupletsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 2, 4, 5];
            long exp = 2;
            long res = alg.CountQuadruplets(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4];
            long exp = 0;
            long res = alg.CountQuadruplets(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
