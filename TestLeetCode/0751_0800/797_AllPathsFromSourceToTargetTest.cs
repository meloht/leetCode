using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _797_AllPathsFromSourceToTargetTest
    {
        _797_AllPathsFromSourceToTargetAlg alg = new _797_AllPathsFromSourceToTargetAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] graph = [[1, 2], [3], [3], []];
            IList<IList<int>> exp = [[0, 1, 3], [0, 2, 3]];
            var res=alg.AllPathsSourceTarget(graph);
           Assert.IsTrue(Utils.IsSame(exp,res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] graph = [[4, 3, 1], [3, 2, 4], [3], [4], []];
            IList<IList<int>> exp = [[0, 4], [0, 3, 4], [0, 1, 3, 4], [0, 1, 2, 3, 4], [0, 1, 4]];
            var res = alg.AllPathsSourceTarget(graph);
            Assert.IsTrue(Utils.IsSame(exp, res));
        }
    }
}
