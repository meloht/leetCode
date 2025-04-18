using leetCode._0901_0950;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _926_FlipStringToMonotoneIncreasingTest
    {
        _926_FlipStringToMonotoneIncreasingAlg alg = new _926_FlipStringToMonotoneIncreasingAlg();
        [Fact]
        public void Test01()
        {
            string s = "00110";
            int exp = 1;
            int res = alg.MinFlipsMonoIncr(s);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string s = "010110";
            int exp = 2;
            int res = alg.MinFlipsMonoIncr(s);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string s = "00011000";
            int exp = 2;
            int res = alg.MinFlipsMonoIncr(s);
            Assert.Equal(exp, res);
        }
    }
}
