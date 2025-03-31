using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _851_LoudAndRichTest
    {
        _851_LoudAndRichAlg alg = new _851_LoudAndRichAlg();

        [Fact]
        public void Test01()
        {
            int[][] richer = [[1, 0], [2, 1], [3, 1], [3, 7], [4, 3], [5, 3], [6, 3]];
            int[] quiet = [3, 2, 5, 4, 6, 1, 7, 0];
            int[] exp = [5, 5, 2, 5, 4, 5, 6, 7];
            int[] res = alg.LoudAndRich(richer, quiet);
            Assert.Equal(exp, res);

        }

        [Fact]
        public void Test02()
        {
            int[][] richer = [];
            int[] quiet = [0];
            int[] exp = [0];
            int[] res = alg.LoudAndRich(richer, quiet);
            Assert.Equal(exp, res);

        }

        [Fact]
        public void Test03()
        {
            int[][] richer = [[0, 1], [1, 2]];
            int[] quiet = [1, 0, 2];
            int[] exp = [0, 1, 1];
            int[] res = alg.LoudAndRich(richer, quiet);
            Assert.Equal(exp, res);

        }

        [Fact]
        public void Test04()
        {
            int[][] richer = [[0, 1], [1, 2]];
            int[] quiet = [0, 1, 2];
            int[] exp = [0, 0, 0];
            int[] res = alg.LoudAndRich(richer, quiet);
            Assert.Equal(exp, res);

        }
    }
}
