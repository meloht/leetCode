using leetCode._1301_1350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1301_1350
{
    [TestClass]
    public class _1338_ReduceArraySizeToTheHalfTest
    {
        _1338_ReduceArraySizeToTheHalfAlg alg = new _1338_ReduceArraySizeToTheHalfAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [3, 3, 3, 3, 5, 5, 5, 2, 2, 7];
            int exp = 2;
            int res = alg.MinSetSize(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [7, 7, 7, 7, 7, 7];
            int exp = 1;
            int res = alg.MinSetSize(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
