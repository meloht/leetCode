using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _507_PerfectNumbeUnitTest
    {
        _507_PerfectNumbeAlg alg = new _507_PerfectNumbeAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 28;
            bool exp = true;
            bool res = alg.CheckPerfectNumber(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 7;
            bool exp = false;
            bool res = alg.CheckPerfectNumber(num);
            Assert.AreEqual(exp, res);
        }
    }
}
