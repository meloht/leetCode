using leetCode._2951_3000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2951_3000
{
    [TestClass]
    public class _2959_NumberOfPossibleSetsOfClosingBranchesTest
    {
        _2959_NumberOfPossibleSetsOfClosingBranchesAlg alg = new _2959_NumberOfPossibleSetsOfClosingBranchesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3, maxDistance = 5;
            int[][] roads = [[0, 1, 2], [1, 2, 10], [0, 2, 10]];
            int exp = 5;
            int res = alg.NumberOfSets(n, maxDistance, roads);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3, maxDistance = 5;
            int[][] roads = [[0, 1, 20], [0, 1, 10], [1, 2, 2], [0, 2, 2]];
            int exp = 7;
            int res = alg.NumberOfSets(n, maxDistance, roads);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 1, maxDistance = 10;
            int[][] roads = [];
            int exp = 2;
            int res = alg.NumberOfSets(n, maxDistance, roads);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int n = 4, maxDistance = 17;
            int[][] roads = [[2, 1, 28], [2, 0, 6], [1, 0, 28], [1, 0, 24], [1, 0, 18], [1, 0, 25], [0, 3, 10]];
            int exp = 8;
            int res = alg.NumberOfSets(n, maxDistance, roads);
            Assert.AreEqual(exp, res);
        }
    }
}
