using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _393_Utf8ValidationUnitTest
    {
        _393_Utf8ValidationAlg alg = new _393_Utf8ValidationAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] data = [197, 130, 1];
            bool exp = true;
            bool res = alg.ValidUtf8(data);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] data = [235, 140, 4];
            bool exp = false;
            bool res = alg.ValidUtf8(data);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] data = [250, 145, 145, 145, 145];
            bool exp = false;
            bool res = alg.ValidUtf8(data);
            Assert.AreEqual(exp, res);
        }
    }
}
