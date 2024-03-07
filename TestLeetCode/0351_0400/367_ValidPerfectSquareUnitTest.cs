using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _367_ValidPerfectSquareUnitTest
    {
        _367_ValidPerfectSquareAlg alg = new _367_ValidPerfectSquareAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 16;
            bool exp = true;
            bool res = alg.IsPerfectSquare(num);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int num = 14;
            bool exp = false;
            bool res = alg.IsPerfectSquare(num);
            Assert.AreEqual(exp, res);
        }
    }
}
