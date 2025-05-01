using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0957_PrisonCellsAfterNDaysTest
    {
        _0957_PrisonCellsAfterNDaysAlg alg = new _0957_PrisonCellsAfterNDaysAlg();

        [Fact]
        public void Test01()
        {
            int[] cells = [0, 1, 0, 1, 1, 0, 0, 1];
            int n = 7;
            int[] exp = [0, 0, 1, 1, 0, 0, 0, 0];
            int[] res = alg.PrisonAfterNDays(cells,n);
            Assert.True(exp.SequenceEqual(res));
        }

        [Fact]
        public void Test02()
        {
            int[] cells = [1, 0, 0, 1, 0, 0, 1, 0];
            int n = 1000000000;
            int[] exp = [0, 0, 1, 1, 1, 1, 1, 0];
            int[] res = alg.PrisonAfterNDays(cells, n);
            Assert.True(exp.SequenceEqual(res));
        }
    }
}
