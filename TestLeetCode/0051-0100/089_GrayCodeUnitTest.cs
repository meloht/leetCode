using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0051_0100
{
    [TestClass]
    public class _89_GrayCodeUnitTest
    {
        _89_GrayCodeAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _89_GrayCodeAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int nn = 8;
            var ssd1 = Convert.ToString(nn, 2);
           
            int dd = 1 << 2;
            var ssd = Convert.ToString(dd, 2);
            int[] exp = { 0, 1, 3, 2 };
            var res = alg.GrayCode(2);
            bool bl = res.ToArray().SequenceEqual(exp);
            Assert.IsTrue(bl);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] exp = { 0, 1 };
            var res = alg.GrayCode(1);
            bool bl = res.ToArray().SequenceEqual(exp);
            Assert.IsTrue(bl);
        }
    }
}
