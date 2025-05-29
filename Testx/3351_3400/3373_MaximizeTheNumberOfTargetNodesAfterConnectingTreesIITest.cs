using leetCode._3351_3400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3373_MaximizeTheNumberOfTargetNodesAfterConnectingTreesIITest
    {
        _3373_MaximizeTheNumberOfTargetNodesAfterConnectingTreesIIAlg alg = new _3373_MaximizeTheNumberOfTargetNodesAfterConnectingTreesIIAlg();

        [Fact]
        public void Test01()
        {
            int[][] edges1 = [[0, 1], [0, 2], [2, 3], [2, 4]], edges2 = [[0, 1], [0, 2], [0, 3], [2, 7], [1, 4], [4, 5], [4, 6]];
            int[] exp = [8, 7, 7, 8, 8];
            int[] res = alg.MaxTargetNodes(edges1, edges2);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] edges1 = [[0, 1], [0, 2], [0, 3], [0, 4]], edges2 = [[0, 1], [1, 2], [2, 3]];
            int[] exp = [3, 6, 6, 6, 6];
            int[] res = alg.MaxTargetNodes(edges1, edges2);
            Assert.Equal(exp, res);
        }
    }
}
