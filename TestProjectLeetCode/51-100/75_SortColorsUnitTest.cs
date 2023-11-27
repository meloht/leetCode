using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _75_SortColorsUnitTest
    {
        _75_SortColorsAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _75_SortColorsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var nums = new int[] { 2, 0, 2, 1, 1, 0 };
            var exp = new int[] { 0, 0, 1, 1, 2, 2 };

            alg.SortColors(nums);
            Assert.AreEqual(true, nums.SequenceEqual(exp));
        }

        [TestMethod]
        public void TestCase02()
        {
            var nums = new int[] { 2, 0, 1 };
            var exp = new int[] { 0, 1, 2 };

            alg.SortColors(nums);
            Assert.AreEqual(true, nums.SequenceEqual(exp));
        }
    }
}
