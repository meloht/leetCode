using leetCode._3351_3400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3351_3400
{
    public class _3372_MaximizeTheNumberOfTargetNodesAfterConnectingTreesITest
    {
        _3372_MaximizeTheNumberOfTargetNodesAfterConnectingTreesIAlg alg = new _3372_MaximizeTheNumberOfTargetNodesAfterConnectingTreesIAlg();

        [Fact]
        public void Test01()
        {
            int[][] edges1 = [[0, 1], [0, 2], [2, 3], [2, 4]], edges2 = [[0, 1], [0, 2], [0, 3], [2, 7], [1, 4], [4, 5], [4, 6]];
            int k = 2;
            int[] exp = [9, 7, 9, 8, 8];
            int[] res = alg.MaxTargetNodes(edges1, edges2, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[][] edges1 = [[0, 1], [0, 2], [0, 3], [0, 4]], edges2 = [[0, 1], [1, 2], [2, 3]];
            int k = 1;
            int[] exp = [6, 3, 3, 3, 3];
            int[] res = alg.MaxTargetNodes(edges1, edges2, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[][] edges1 = [[0, 1]], edges2 = [[0, 1]];
            int k = 0;
            int[] exp = [1, 1];
            int[] res = alg.MaxTargetNodes(edges1, edges2, k);
            Assert.Equal(exp, res);
        }
    }
}
