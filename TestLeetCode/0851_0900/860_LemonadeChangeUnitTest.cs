using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0851_0900
{
    [TestClass]
    public class _860_LemonadeChangeUnitTest
    {
        _860_LemonadeChangeAlg alg = new _860_LemonadeChangeAlg();
        [TestMethod]
        public void TestCase01()
        {
            int[] bills = [5, 5, 5, 10, 20];
            bool exp = true;
            bool res = alg.LemonadeChange(bills);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] bills = [5, 5, 10, 10, 20];
            bool exp = false;
            bool res = alg.LemonadeChange(bills);
            Assert.AreEqual(exp, res);

        }
    }
}
