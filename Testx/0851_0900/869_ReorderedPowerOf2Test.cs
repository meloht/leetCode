using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _869_ReorderedPowerOf2Test
    {
        _869_ReorderedPowerOf2Alg alg = new _869_ReorderedPowerOf2Alg();

        [Fact]
        public void Test01()
        {
            int n = 1;
            bool exp = true;
            bool res = alg.ReorderedPowerOf2(n);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int n = 10;
            bool exp = false;
            bool res = alg.ReorderedPowerOf2(n);
            Assert.Equal(exp, res);
        }
    }
}
