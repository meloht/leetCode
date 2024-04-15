using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _728_SelfDividingNumbersUnitTest
    {
        _728_SelfDividingNumbersAlg alg = new _728_SelfDividingNumbersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int left = 1, right = 22;
            int[] exp = [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22];
            int[] res = alg.SelfDividingNumbers(left, right).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int left = 1, right = 22;
            int[] exp = [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22];
            int[] res = alg.SelfDividingNumbers(left, right).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
