using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _858_MirrorReflectionTest
    {
        _858_MirrorReflectionAlg alg = new _858_MirrorReflectionAlg();

        [Fact]
        public void Test01()
        {
            int p = 2, q = 1;
            int exp = 2;
            int res = alg.MirrorReflection(p, q);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int p = 3, q = 1;
            int exp = 1;
            int res = alg.MirrorReflection(p, q);
            Assert.Equal(exp, res);
        }
    }
}
