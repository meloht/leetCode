using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0501_0550._528_RandomPickWithWeightAlg;

namespace Test._0351_0400
{
    [TestClass]
    public class _384_ShuffleAnArrayUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _384_ShuffleAnArrayAlg solution = new _384_ShuffleAnArrayAlg([1, 2, 3]);
            solution.Shuffle();    // 打乱数组 [1,2,3] 并返回结果。任何 [1,2,3]的排列返回的概率应该相同。例如，返回 [3, 1, 2]
            solution.Reset();      // 重设数组到它的初始状态 [1, 2, 3] 。返回 [1, 2, 3]
            solution.Shuffle();    // 随机返回数组 [1, 2, 3] 打乱后的结果。例如，返回 [1, 3, 2]
        }
    }
}
