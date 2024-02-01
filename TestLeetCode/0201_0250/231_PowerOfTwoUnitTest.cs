using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _231_PowerOfTwoUnitTest
    {
        _231_PowerOfTwoAlg alg = new _231_PowerOfTwoAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 1;
            bool exp = true;
            var res = alg.IsPowerOfTwo(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 16;
            bool exp = true;
            var res = alg.IsPowerOfTwo(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 3;
            bool exp = false;
            var res = alg.IsPowerOfTwo(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int n = 4;
            bool exp = true;
            var res = alg.IsPowerOfTwo(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int n = 5;
            bool exp = false;
            var res = alg.IsPowerOfTwo(n);
            Assert.AreEqual(exp, res);
        }
    }
}
