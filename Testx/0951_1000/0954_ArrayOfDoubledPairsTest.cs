using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0954_ArrayOfDoubledPairsTest
    {
        _0954_ArrayOfDoubledPairsAlg alg = new _0954_ArrayOfDoubledPairsAlg();

        [Fact]
        public void Test01()
        {
            int[] arr = [3, 1, 3, 6];
            bool exp = false;
            bool res = alg.CanReorderDoubled(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] arr = [2, 1, 2, 6];
            bool exp = false;
            bool res = alg.CanReorderDoubled(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] arr = [4, -2, 2, -4];
            bool exp = true;
            bool res = alg.CanReorderDoubled(arr);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int[] arr = [2, 4, 0, 0, 8, 1];
            bool exp = true;
            bool res = alg.CanReorderDoubled(arr);
            Assert.Equal(exp, res);
        }


        [Fact]
        public void Test05()
        {
            int[] arr = [1, 2, 4, 16, 8, 4];
            bool exp = false;
            bool res = alg.CanReorderDoubled(arr);
            Assert.Equal(exp, res);
        }
    }
}
