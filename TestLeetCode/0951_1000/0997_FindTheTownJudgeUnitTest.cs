using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0997_FindTheTownJudgeUnitTest
    {
        _0997_FindTheTownJudgeAlg alg = new _0997_FindTheTownJudgeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int[][] trust = [[1, 2]];
            int exp = 2;
            int res = alg.FindJudge(n, trust);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            int[][] trust = [[1, 3], [2, 3]];
            int exp = 3;
            int res = alg.FindJudge(n, trust);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int n = 3;
            int[][] trust = [[1, 3], [2, 3], [3, 1]];
            int exp = -1;
            int res = alg.FindJudge(n, trust);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 4;
            int[][] trust = [[1, 3], [1, 4], [2, 3], [2, 4], [4, 3]];
            int exp = 3;
            int res = alg.FindJudge(n, trust);
            Assert.AreEqual(exp, res);
        }
    }
}
