using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _319_BulbSwitcherUnitTest
    {
        _319_BulbSwitcherAlg alg = new _319_BulbSwitcherAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            int exp = 1;
            int res = alg.BulbSwitch(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 0;
            int exp = 0;
            int res = alg.BulbSwitch(n);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            int n = 1;
            int exp = 1;
            int res = alg.BulbSwitch(n);
            Assert.AreEqual(exp, res);
        }

    }
}
