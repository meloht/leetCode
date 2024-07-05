using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _453_MinimumMovesToEqualArrayElementsTest
    {
        _453_MinimumMovesToEqualArrayElementsAlg alg = new _453_MinimumMovesToEqualArrayElementsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            int exp = 3;
            int res = alg.MinMoves(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 1, 1];
            int exp = 0;
            int res = alg.MinMoves(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
