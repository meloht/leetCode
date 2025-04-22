using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _932_BeautifulArrayTest
    {
        _932_BeautifulArrayAlg alg = new _932_BeautifulArrayAlg();

        [Fact]
        public void Test01()
        {
            int n = 4;
            int[] exp = [2, 1, 4, 3];
            int[] res = alg.BeautifulArray(n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int n = 5;
            int[] exp = [3, 1, 2, 5, 4];
            int[] res = alg.BeautifulArray(n);
            Assert.Equal(exp, res);
        }
    }
}
