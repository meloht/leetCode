using leetCode._1451_1500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1451_1500
{
    [TestClass]
    public class _1463_CherryPickupIIUnitTest
    {
        _1463_CherryPickupIIAlg alg = new _1463_CherryPickupIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[3, 1, 1], [2, 5, 1], [1, 5, 5], [2, 1, 1]];
            int exp = 24;
            int res = alg.CherryPickup(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[1, 0, 0, 0, 0, 0, 1], [2, 0, 0, 0, 0, 3, 0], [2, 0, 9, 0, 0, 0, 0], [0, 3, 0, 5, 4, 0, 0], [1, 0, 2, 3, 0, 0, 6]];
            int exp = 28;
            int res = alg.CherryPickup(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [[1, 0, 0, 3], [0, 0, 0, 3], [0, 0, 3, 3], [9, 0, 3, 3]];
            int exp = 22;
            int res = alg.CherryPickup(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] grid = [[1, 1], [1, 1]];
            int exp = 4;
            int res = alg.CherryPickup(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
