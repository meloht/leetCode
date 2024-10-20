using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _519_RandomFlipMatrixTest
    {
        [TestMethod]
        public void TestCase01()
        {
            _519_RandomFlipMatrixAlg.Solution solution = new _519_RandomFlipMatrixAlg.Solution(3, 1);
            solution.Flip();  // 返回 [1, 0]，此时返回 [0,0]、[1,0] 和 [2,0] 的概率应当相同
            solution.Flip();  // 返回 [2, 0]，因为 [1,0] 已经返回过了，此时返回 [2,0] 和 [0,0] 的概率应当相同
            solution.Flip();  // 返回 [0, 0]，根据前面已经返回过的下标，此时只能返回 [0,0]
            solution.Reset(); // 所有值都重置为 0 ，并可以再次选择下标返回
            solution.Flip();  // 返回 [2, 0]，此时返回 [0,0]、[1,0] 和 [2,0] 的概率应当相同
        }
    }
}
