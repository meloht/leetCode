using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _162_FindPeakElementUnitTest
    {
        _162_FindPeakElementAlg alg = new _162_FindPeakElementAlg();


        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 1];
            int exp = 2;
            int res = alg.FindPeakElement(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 1, 3, 5, 6, 4];
            int[] exp = [1,5];
            int res = alg.FindPeakElement(nums);
            Assert.IsTrue(exp.Contains(res));
        }
    }
}
