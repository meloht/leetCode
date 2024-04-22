using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0989_AddToArrayFormOfIntegerUnitTest
    {
        _0989_AddToArrayFormOfIntegerAlg alg = new _0989_AddToArrayFormOfIntegerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] num = [1, 2, 0, 0];
            int k = 34;
            int[] exp = [1, 2, 3, 4];
            int[] res = alg.AddToArrayForm(num, k).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] num = [2, 7, 4];
            int k = 181;
            int[] exp = [4, 5, 5];
            int[] res = alg.AddToArrayForm(num, k).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] num = [2, 1, 5];
            int k = 806;
            int[] exp = [1, 0, 2, 1];
            int[] res = alg.AddToArrayForm(num, k).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
