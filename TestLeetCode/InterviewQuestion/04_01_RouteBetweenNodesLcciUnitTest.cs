using leetCode._0551_0600;
using leetCode.InterviewQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.InterviewQuestion
{
    [TestClass]
    public class _04_01_RouteBetweenNodesLcciUnitTest
    {
        _04_01_RouteBetweenNodesLcciAlg alg = new _04_01_RouteBetweenNodesLcciAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] graph = [[0, 1], [0, 2], [1, 2], [1, 2]];
            int n = 3, start = 0, target = 2;
            bool exp = true;
            bool res = alg.FindWhetherExistsPath(n, graph, start, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] graph = [[0, 1], [0, 2], [0, 4], [0, 4], [0, 1], [1, 3], [1, 4], [1, 3], [2, 3], [3, 4]];
            int n = 5, start = 0, target = 4;
            bool exp = true;
            bool res = alg.FindWhetherExistsPath(n, graph, start, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] graph = [[0, 1], [1, 2], [1, 3], [1, 10], [1, 11], [1, 4], [2, 4], [2, 6], [2, 9], [2, 10], [2, 4], [2, 5], [2, 10], [3, 7], [3, 7], [4, 5], [4, 11], [4, 11], [4, 10], [5, 7], [5, 10], [6, 8], [7, 11], [8, 10]];
            int n = 12, start = 2, target = 3;
            bool exp = false;
            bool res = alg.FindWhetherExistsPath(n, graph, start, target);
            Assert.AreEqual(exp, res);
        }
    }
}
