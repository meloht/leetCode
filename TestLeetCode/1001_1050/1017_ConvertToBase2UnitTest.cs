using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1017_ConvertToBase2UnitTest
    {
        _1017_ConvertToBase2Alg alg = new _1017_ConvertToBase2Alg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            string exp = "110";
            string res = alg.BaseNeg2(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            string exp = "111";
            string res = alg.BaseNeg2(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 3;
            string exp = "100";
            string res = alg.BaseNeg2(n);
            Assert.AreEqual(exp, res);
        }
    }
}
