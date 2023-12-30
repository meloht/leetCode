using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _202_HappyNumberUnitTest
    {
        _202_HappyNumberAlg alg = new _202_HappyNumberAlg();

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.IsHappy(19);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.IsHappy(2);
            Assert.AreEqual(false, res);
        }

    }
}
