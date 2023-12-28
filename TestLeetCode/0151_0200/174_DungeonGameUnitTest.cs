using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _174_DungeonGameUnitTest
    {
        _174_DungeonGameAlg alg = new _174_DungeonGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] dungeon = [[-2, -3, 3], [-5, -10, 1], [10, 30, -5]];
            int res = alg.CalculateMinimumHP(dungeon);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] dungeon = [[0]];
            int res = alg.CalculateMinimumHP(dungeon);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[][] dungeon = [[100]];
            int res = alg.CalculateMinimumHP(dungeon);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[][] dungeon = [[-3, 5]];
            int res = alg.CalculateMinimumHP(dungeon);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[][] dungeon = [[1, -3, 3], [0, -2, 0], [-3, -3, -3]];
            int res = alg.CalculateMinimumHP(dungeon);
            Assert.AreEqual(3, res);
        }
    }
}
