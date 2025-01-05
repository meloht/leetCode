using leetCode._0651_0700;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _675_CutOffTreesForGolfEventTest
    {
        _675_CutOffTreesForGolfEventAlg alg = new _675_CutOffTreesForGolfEventAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            int[][] forest = [[1, 2, 3], [0, 0, 4], [7, 6, 5]];
            int exp = 6;
            int res = alg.CutOffTree(forest);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] forest = [[1, 2, 3], [0, 0, 0], [7, 6, 5]];
            int exp = -1;
            int res = alg.CutOffTree(forest);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] forest = [[2, 3, 4], [0, 0, 5], [8, 7, 6]];
            int exp = 6;
            int res = alg.CutOffTree(forest);
            Assert.AreEqual(exp, res);
        }
    }
}
