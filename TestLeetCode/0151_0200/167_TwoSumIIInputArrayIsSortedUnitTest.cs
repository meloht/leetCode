using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _167_TwoSumIIInputArrayIsSortedUnitTest
    {
        _167_TwoSumIIInputArrayIsSortedAlg alg = new _167_TwoSumIIInputArrayIsSortedAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] numbers = [2, 7, 11, 15];
            var res = alg.TwoSum(numbers, 9);
            int[] exp = [1, 2];
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] numbers = [2, 3, 4];
            var res = alg.TwoSum(numbers, 6);
            int[] exp = [1, 3];
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] numbers = [-1, 0];
            var res = alg.TwoSum(numbers, -1);
            int[] exp = [1, 2];
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
