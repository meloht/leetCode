using leetCode._2351_2400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2351_2400
{
    public class _2359_FindClosestNodeToGivenTwoNodesTest
    {
        _2359_FindClosestNodeToGivenTwoNodesAlg alg = new _2359_FindClosestNodeToGivenTwoNodesAlg();

        [Fact]
        public void Test01()
        {
            int[] edges = [2, 2, 3, -1];
            int node1 = 0, node2 = 1;
            int exp = 2;
            int res = alg.ClosestMeetingNode(edges, node1, node2);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] edges = [1, 2, -1];
            int node1 = 0, node2 = 2;
            int exp = 2;
            int res = alg.ClosestMeetingNode(edges, node1, node2);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] edges = [5, 3, 1, 0, 2, 4, 5];
            int node1 = 3, node2 = 2;
            int exp = 3;
            int res = alg.ClosestMeetingNode(edges, node1, node2);
            Assert.Equal(exp, res);
        }
    }
}
