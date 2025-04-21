using leetCode._2151_2200;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._2151_2200
{
    public class _2145_CountTheHiddenSequencesTest
    {
        _2145_CountTheHiddenSequencesAlg alg = new _2145_CountTheHiddenSequencesAlg();
        [Fact]
        public void Test01()
        {
            int[] differences = [1, -3, 4];
            int lower = 1, upper = 6;
            int exp = 2;
            int res = alg.NumberOfArrays(differences, lower, upper);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] differences = [3, -4, 5, 1, -2];
            int lower = -4, upper = 5;
            int exp = 4;
            int res = alg.NumberOfArrays(differences, lower, upper);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            int[] differences = [4, -7, 2];
            int lower = 3, upper = 6;
            int exp = 0;
            int res = alg.NumberOfArrays(differences, lower, upper);
            Assert.Equal(exp, res);
        }
    }
}
