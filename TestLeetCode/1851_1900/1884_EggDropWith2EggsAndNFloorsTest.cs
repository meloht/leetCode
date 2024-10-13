using leetCode._1851_1900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1851_1900
{
    [TestClass]
    public class _1884_EggDropWith2EggsAndNFloorsTest
    {
        _1884_EggDropWith2EggsAndNFloorsAlg alg = new _1884_EggDropWith2EggsAndNFloorsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 2;
            int exp = 2;
            int res = alg.TwoEggDrop(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 100;
            int exp = 14;
            int res = alg.TwoEggDrop(n);
            Assert.AreEqual(exp, res);
        }
    }
}
