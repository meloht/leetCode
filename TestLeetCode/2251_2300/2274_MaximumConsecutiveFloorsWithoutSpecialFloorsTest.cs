using leetCode._2251_2300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2251_2300
{
    [TestClass]
    public class _2274_MaximumConsecutiveFloorsWithoutSpecialFloorsTest
    {
        _2274_MaximumConsecutiveFloorsWithoutSpecialFloorsAlg alg = new _2274_MaximumConsecutiveFloorsWithoutSpecialFloorsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int bottom = 2, top = 9;
            int[] special = [4, 6];
            int exp = 3;
            int res = alg.MaxConsecutive(bottom, top, special);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int bottom = 6, top = 8;
            int[] special = [7, 6, 8];
            int exp = 0;
            int res = alg.MaxConsecutive(bottom, top, special);
            Assert.AreEqual(exp, res);
        }
    }
}
