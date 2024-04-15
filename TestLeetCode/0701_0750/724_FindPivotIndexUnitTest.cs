using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _724_FindPivotIndexUnitTest
    {
        _724_FindPivotIndexAlg alg = new _724_FindPivotIndexAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 7, 3, 6, 5, 6];
            int exp = 3;
            int res = alg.PivotIndex(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3];
            int exp = -1;
            int res = alg.PivotIndex(nums);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 1, -1];
            int exp = 0;
            int res = alg.PivotIndex(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
