using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1046_LastStoneWeightUnitTest
    {
        _1046_LastStoneWeightAlg alg = new _1046_LastStoneWeightAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [2, 7, 4, 1, 8, 1];
            int exp = 1;
            int res = alg.LastStoneWeight(arr);
            Assert.AreEqual(exp, res);
        }


    }
}
