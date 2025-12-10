using leetCode._3551_3600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3551_3600
{
    public class _3577_CountTheNumberOfComputerUnlockingPermutationsTest
    {
        _3577_CountTheNumberOfComputerUnlockingPermutationsAlg alg = new _3577_CountTheNumberOfComputerUnlockingPermutationsAlg();

        [Fact]
        public void Test1()
        {
            int[] complexity = [1, 2, 3];
            int exp = 2;
            int res = alg.CountPermutations(complexity);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test2()
        {
            int[] complexity = [3, 3, 3, 4, 4, 4];
            int exp = 0;
            int res = alg.CountPermutations(complexity);
            Assert.Equal(exp, res);
        }
    }
}
