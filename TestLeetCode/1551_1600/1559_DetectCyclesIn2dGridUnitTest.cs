using leetCode._1551_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1559_DetectCyclesIn2dGridUnitTest
    {
        _1559_DetectCyclesIn2dGridAlg alg = new _1559_DetectCyclesIn2dGridAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] grid = [['a', 'a', 'a', 'a'], ['a', 'b', 'b', 'a'], ['a', 'b', 'b', 'a'], ['a', 'a', 'a', 'a']];
            bool exp = true;
            bool res = alg.ContainsCycle(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] grid = [['c', 'c', 'c', 'a'], ['c', 'd', 'c', 'c'], ['c', 'c', 'e', 'c'], ['f', 'c', 'c', 'c']];
            bool exp = true;
            bool res = alg.ContainsCycle(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] grid = [['a', 'b', 'b'], ['b', 'z', 'b'], ['b', 'b', 'a']];
            bool exp = false;
            bool res = alg.ContainsCycle(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
