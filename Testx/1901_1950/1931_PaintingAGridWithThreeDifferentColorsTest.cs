using leetCode._1901_1950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1901_1950
{
    public class _1931_PaintingAGridWithThreeDifferentColorsTest
    {
        _1931_PaintingAGridWithThreeDifferentColorsAlg alg = new _1931_PaintingAGridWithThreeDifferentColorsAlg();

        [Fact]
        public void Test01()
        {
            int m = 1, n = 1;
            int exp = 3;
            int res = alg.ColorTheGrid(m, n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int m = 1, n = 2;
            int exp = 6;
            int res = alg.ColorTheGrid(m, n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test06()
        {
            int m = 5, n = 5;
            int exp = 580986;
            int res = alg.ColorTheGrid(m, n);
            Assert.Equal(exp, res);
        }
    }
}
