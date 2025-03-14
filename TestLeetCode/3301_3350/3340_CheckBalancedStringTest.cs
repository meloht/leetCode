using leetCode._3301_3350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3301_3350
{
    [TestClass]
    public class _3340_CheckBalancedStringTest
    {
        _3340_CheckBalancedStringAlg alg = new _3340_CheckBalancedStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num = "1234";
            bool exp = false;
            bool res = alg.IsBalanced(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string num = "24123";
            bool exp = true;
            bool res = alg.IsBalanced(num);
            Assert.AreEqual(exp, res);
        }
    }
}
