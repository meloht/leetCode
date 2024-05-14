using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _371_SumOfTwoIntegersUnitTest
    {
        _371_SumOfTwoIntegersAlg alg = new _371_SumOfTwoIntegersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int a = 1, b = 2;
            int exp = 3;
            int res = alg.GetSum(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int a = 2, b = 3;
            int exp = 5;
            int res = alg.GetSum(a, b);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int a = 1, b = -1;
            int exp = 0;
            int res = alg.GetSum(a, b);
            Assert.AreEqual(exp, res);
        }
    }
}
