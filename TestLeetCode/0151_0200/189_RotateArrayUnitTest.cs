using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _189_RotateArrayUnitTest
    {
        _189_RotateArrayAlg alg = new _189_RotateArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            int[] exp = [5, 6, 7, 1, 2, 3, 4];
            alg.Rotate(nums, 3);
            Assert.IsTrue(exp.SequenceEqual(nums));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-1, -100, 3, 99];
            int[] exp = [3, 99, -1, -100];
            alg.Rotate(nums, 2);
            Assert.IsTrue(exp.SequenceEqual(nums));
        }
    }
}
