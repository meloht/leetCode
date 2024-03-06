using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _344_ReverseStringUnitTest
    {
        _344_ReverseStringAlg alg = new _344_ReverseStringAlg();
        [TestMethod]
        public void TestCase01()
        {
            char[] s = ['h', 'e', 'l', 'l', 'o'];
            char[] exp = ['o', 'l', 'l', 'e', 'h'];
            alg.ReverseString(s);
            Assert.IsTrue(exp.SequenceEqual(s));
        }

        [TestMethod]
        public void TestCase02()
        {
            char[] s = ['H', 'a', 'n', 'n', 'a', 'h'];
            char[] exp = ['h', 'a', 'n', 'n', 'a', 'H'];
            alg.ReverseString(s);
            Assert.IsTrue(exp.SequenceEqual(s));
        }
    }
}
