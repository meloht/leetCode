using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0951_1000
{
    public class _0967_NumbersWithSameConsecutiveDifferencesTest
    {
        _0967_NumbersWithSameConsecutiveDifferencesAlg alg = new _0967_NumbersWithSameConsecutiveDifferencesAlg();

        [Fact]
        public void Test01()
        {
            int n = 3, k = 7;
            int[] exp = [181, 292, 707, 818, 929];
            int[] res = alg.NumsSameConsecDiff(n, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int n = 2, k = 1;
            int[] exp = [10, 12, 21, 23, 32, 34, 43, 45, 54, 56, 65, 67, 76, 78, 87, 89, 98];
            int[] res = alg.NumsSameConsecDiff(n, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int n = 2, k = 0;
            int[] exp = [11, 22, 33, 44, 55, 66, 77, 88, 99];
            int[] res = alg.NumsSameConsecDiff(n, k);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test04()
        {
            int n = 2, k = 2;
            int[] exp = [13, 20, 24, 31, 35, 42, 46, 53, 57, 64, 68, 75, 79, 86, 97];
            int[] res = alg.NumsSameConsecDiff(n, k);
            Assert.Equal(exp, res);
        }
    }
}
