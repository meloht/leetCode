using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3142_CheckIfGridSatisfiesConditionsTest
    {
        _3142_CheckIfGridSatisfiesConditionsAlg alg = new _3142_CheckIfGridSatisfiesConditionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[1, 0, 2], [1, 0, 2]];
            bool exp = true;
            bool res = alg.SatisfiesConditions(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 1, 1], [0, 0, 0]];
            bool exp = false;
            bool res = alg.SatisfiesConditions(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1], [2], [3]];
            bool exp = false;
            bool res = alg.SatisfiesConditions(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
