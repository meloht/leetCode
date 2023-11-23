using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _69_SqrtxUnitTest
    {
        _69_SqrtxAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _69_SqrtxAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int res = alg.MySqrt(4);
            int exp = 2;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int res = alg.MySqrt(8);
            int exp = 2;
            Assert.AreEqual(exp, res);
        }
    }
}
