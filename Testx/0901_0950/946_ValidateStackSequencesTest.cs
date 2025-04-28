using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _946_ValidateStackSequencesTest
    {
        _946_ValidateStackSequencesAlg alg = new _946_ValidateStackSequencesAlg();

        [Fact]
        public void Test01()
        {
            int[] pushed = [1, 2, 3, 4, 5], popped = [4, 5, 3, 2, 1];
            bool exp = true;
            bool res = alg.ValidateStackSequences(pushed, popped);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            int[] pushed = [1, 2, 3, 4, 5], popped = [4, 3, 5, 1, 2];
            bool exp = false;
            bool res = alg.ValidateStackSequences(pushed, popped);
            Assert.Equal(exp, res);
        }
    }
}
