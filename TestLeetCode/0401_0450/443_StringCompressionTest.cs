using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _443_StringCompressionTest
    {
        _443_StringCompressionAlg alg = new _443_StringCompressionAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[] chars = ['a', 'a', 'b', 'b', 'c', 'c', 'c'];
            int exp = 6;
            int res = alg.Compress(chars);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[] chars = ['a'];
            int exp = 1;
            int res = alg.Compress(chars);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[] chars = ['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'];
            int exp = 4;
            int res = alg.Compress(chars);
            Assert.AreEqual(exp, res);
        }
    }
}
