using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _97_InterleavingStringUnitTest
    {
        _97_InterleavingStringAlg alg = new _97_InterleavingStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            bool res = alg.IsInterleave("aabcc", "dbbca", "aadbbcbcac");
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            bool res = alg.IsInterleave("aabcc", "dbbca", "aadbbbaccc");
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            bool res = alg.IsInterleave("", "", "");
            Assert.AreEqual(true, res);
        }
    }
}
