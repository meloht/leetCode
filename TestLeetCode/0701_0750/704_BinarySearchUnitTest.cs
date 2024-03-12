using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _704_BinarySearchUnitTest
    {
        _704_BinarySearchAlg alg = new _704_BinarySearchAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [-1, 0, 3, 5, 9, 12];
            int target = 9;
            int exp = 4;
            int res = alg.Search(nums, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-1, 0, 3, 5, 9, 12];
            int target = 2;
            int exp = -1;
            int res = alg.Search(nums, target);
            Assert.AreEqual(exp, res);
        }

    }
}
