using leetCode._1951_2000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1951_2000
{
    [TestClass]
    public class _1963_MinimumNumberOfSwapsToMakeTheStringBalancedTest
    {
        _1963_MinimumNumberOfSwapsToMakeTheStringBalancedAlg alg = new _1963_MinimumNumberOfSwapsToMakeTheStringBalancedAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "][][";
            int exp = 1;
            int res = alg.MinSwaps(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "]]][[[";
            int exp = 2;
            int res = alg.MinSwaps(s);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            string s = "[]";
            int exp = 0;
            int res = alg.MinSwaps(s);
            Assert.AreEqual(exp, res);
        }
    }
}
