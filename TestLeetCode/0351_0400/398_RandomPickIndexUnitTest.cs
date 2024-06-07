using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test._0351_0400
{
    [TestClass]
    public class _398_RandomPickIndexUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _398_RandomPickIndexAlg.Solution solution = new _398_RandomPickIndexAlg.Solution([1, 2, 3, 3, 3]);
            solution.Pick(3); // 随机返回索引 2, 3 或者 4 之一。每个索引的返回概率应该相等。
            Assert.AreEqual(0, solution.Pick(1)); // 返回 0 。因为只有 nums[0] 等于 1 。
            solution.Pick(3); // 随机返回索引 2, 3 或者 4 之一。每个索引的返回概率应该相等。
        }
    }
}
