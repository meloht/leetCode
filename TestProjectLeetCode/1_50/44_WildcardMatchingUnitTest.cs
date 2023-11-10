using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._1_50
{
    [TestClass]
    public class _44_WildcardMatchingUnitTest
    {
        _44_WildcardMatchingAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _44_WildcardMatchingAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var s = "aa";
            var p = "a";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            var s = "aa";
            var p = "*";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            var s = "cb";
            var p = "?a";
            var res = alg.IsMatch(s, p);
            Assert.AreEqual(false, res);
        }
    }
}
