using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0301_0350._303_RangeSumQueryImmutableAlg;

namespace Test._0301_0350
{
    [TestClass]
    public class _303_RangeSumQueryImmutableUnitTest
    {

        [TestMethod]
        public void TestCase01()
        {
            NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
            Assert.AreEqual(numArray.SumRange(0, 2), 1); // return 1 ((-2) + 0 + 3)
            Assert.AreEqual(numArray.SumRange(2, 5), -1); // return -1 (3 + (-5) + 2 + (-1)) 
            Assert.AreEqual(numArray.SumRange(0, 5), -3); // return -3 ((-2) + 0 + 3 + (-5) + 2 + (-1))
        }


    }
}
