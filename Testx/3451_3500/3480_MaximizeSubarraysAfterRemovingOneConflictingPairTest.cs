using leetCode._3451_3500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._3451_3500
{
    public class _3480_MaximizeSubarraysAfterRemovingOneConflictingPairTest
    {
        _3480_MaximizeSubarraysAfterRemovingOneConflictingPairAlg alg = new _3480_MaximizeSubarraysAfterRemovingOneConflictingPairAlg();
        
        [Fact]
        public void TestCase01()
        {
            int n = 4;
            int[][] conflictingPairs = [[2, 3], [1, 4]];
            long exp = 9;
            long res = alg.MaxSubarrays(n, conflictingPairs);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void TestCase02()
        {
            int n = 5;
            int[][] conflictingPairs = [[1, 2], [2, 5], [3, 5]];
            long exp = 12;
            long res = alg.MaxSubarrays(n, conflictingPairs);
            Assert.Equal(exp, res);
        }
    }
}
