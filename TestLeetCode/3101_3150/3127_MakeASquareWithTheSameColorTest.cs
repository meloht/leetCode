using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3127_MakeASquareWithTheSameColorTest
    {
        _3127_MakeASquareWithTheSameColorAlg alg = new _3127_MakeASquareWithTheSameColorAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] grid = [['B', 'W', 'B'], ['B', 'W', 'W'], ['B', 'W', 'B']];
            bool exp = true;
            bool res=alg.CanMakeSquare(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] grid = [['B', 'W', 'B'], ['W', 'B', 'W'], ['B', 'W', 'B']];
            bool exp = false;
            bool res = alg.CanMakeSquare(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] grid = [['B', 'W', 'B'], ['B', 'W', 'W'], ['B', 'W', 'W']];
            bool exp = true;
            bool res = alg.CanMakeSquare(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
