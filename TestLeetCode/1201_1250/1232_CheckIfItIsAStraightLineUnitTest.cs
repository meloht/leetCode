using leetCode._1201_1250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1201_1250
{
    [TestClass]
    public class _1232_CheckIfItIsAStraightLineUnitTest
    {
        _1232_CheckIfItIsAStraightLineAlg alg = new _1232_CheckIfItIsAStraightLineAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] coordinates = [[1, 2], [2, 3], [3, 4], [4, 5], [5, 6], [6, 7]];
            bool exp = true;
            bool res = alg.CheckStraightLine(coordinates);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] coordinates = [[1, 1], [2, 2], [3, 4], [4, 5], [5, 6], [7, 7]];
            bool exp = false;
            bool res = alg.CheckStraightLine(coordinates);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] coordinates = [[0, 0], [0, 1], [0, -1]];
            bool exp = true;
            bool res = alg.CheckStraightLine(coordinates);
            Assert.AreEqual(exp, res);
        }
    }
}
