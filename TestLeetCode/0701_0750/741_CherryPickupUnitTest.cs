using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _741_CherryPickupUnitTest
    {
        _741_CherryPickupAlg alg = new _741_CherryPickupAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 1, -1], [1, 0, -1], [1, 1, 1]];
            int exp = 5;
            int res = alg.CherryPickup(grid);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 1, -1], [1, -1, 1], [-1, 1, 1]];
            int exp = 0;
            int res = alg.CherryPickup(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
