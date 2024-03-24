using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _307_RangeSumQueryMutableUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 3, 5];
            _307_RangeSumQueryMutableAlg.NumArray numArray = new _307_RangeSumQueryMutableAlg.NumArray(nums);

            Assert.AreEqual(9, numArray.SumRange(0, 2)); // 返回 1 + 3 + 5 = 9
            numArray.Update(1, 2);   // nums = [1,2,5]
            Assert.AreEqual(8, numArray.SumRange(0, 2)); // 返回 1 + 2 + 5 = 8
        }
    }
}
