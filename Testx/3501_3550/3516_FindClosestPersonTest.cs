using leetCode._3501_3550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3501_3550
{
    public class _3516_FindClosestPersonTest
    {
        _3516_FindClosestPersonAlg alg = new _3516_FindClosestPersonAlg();

        [Fact]
        public void Test1()
        {
            int x = 2, y = 7, z = 4;
            int exp = 1;
            int res = alg.FindClosest(x, y, z);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int x = 2, y = 5, z = 6;
            int exp = 2;
            int res = alg.FindClosest(x, y, z);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test3()
        {
            int x = 1, y = 5, z = 3;
            int exp = 0;
            int res = alg.FindClosest(x, y, z);
            Assert.Equal(exp, res);
        }
    }
}
