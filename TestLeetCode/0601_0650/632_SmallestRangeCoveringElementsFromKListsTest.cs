using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _632_SmallestRangeCoveringElementsFromKListsTest
    {
        _632_SmallestRangeCoveringElementsFromKListsAlg alg = new _632_SmallestRangeCoveringElementsFromKListsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] nums = [[4, 10, 15, 24, 26], [0, 9, 12, 20], [5, 18, 22, 30]];
            int[] exp = [20, 24];
            int[] res = alg.SmallestRange(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] nums = [[1, 2, 3], [1, 2, 3], [1, 2, 3]];
            int[] exp = [1, 1];
            int[] res = alg.SmallestRange(nums);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
