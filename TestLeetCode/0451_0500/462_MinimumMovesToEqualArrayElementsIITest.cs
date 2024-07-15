using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _462_MinimumMovesToEqualArrayElementsIITest
    {
        _462_MinimumMovesToEqualArrayElementsIIAlg alg = new _462_MinimumMovesToEqualArrayElementsIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            int exp = 2;
            int res = alg.MinMoves2(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 10, 2, 9];
            int exp = 16;
            int res = alg.MinMoves2(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
