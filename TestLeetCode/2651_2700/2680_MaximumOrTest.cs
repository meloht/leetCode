using leetCode._2651_2700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2651_2700
{
    [TestClass]
    public class _2680_MaximumOrTest
    {
        _2680_MaximumOrAlg alg = new _2680_MaximumOrAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [12, 9];
            int k = 1;
            long exp = 30;
            long res = alg.MaximumOr(nums, k);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [8, 1, 2];
            int k = 2;
            long exp = 35;
            long res = alg.MaximumOr(nums, k);
            Assert.AreEqual(exp, res);

        }
    }
}
