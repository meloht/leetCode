using leetCode._1851_1900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1851_1900
{
    public class _1857_LargestColorValueInADirectedGraphTest
    {
        _1857_LargestColorValueInADirectedGraphAlg alg=new _1857_LargestColorValueInADirectedGraphAlg()'

        [Fact]
        public void Test01()
        {
            string colors = "abaca";
            int[][] edges = [[0, 1], [0, 2], [2, 3], [3, 4]];
            int exp = 3;
            int res = alg.LargestPathValue(colors, edges);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string colors = "a";
            int[][] edges = [[0, 0]];
            int exp = -1;
            int res = alg.LargestPathValue(colors, edges);
            Assert.Equal(exp, res);
        }
    }
}
