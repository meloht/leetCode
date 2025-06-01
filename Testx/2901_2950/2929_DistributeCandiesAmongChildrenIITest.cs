using leetCode._2901_2950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2901_2950
{
    public class _2929_DistributeCandiesAmongChildrenIITest
    {
        _2929_DistributeCandiesAmongChildrenIIAlg alg = new _2929_DistributeCandiesAmongChildrenIIAlg();

        [Fact]
        public void Test01()
        {
            int n = 5, limit = 2;
            long exp = 3;
            long res = alg.DistributeCandies(n, limit);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int n = 3, limit = 3;
            long exp = 10;
            long res = alg.DistributeCandies(n, limit);
            Assert.Equal(exp, res);
        }
    }
}
