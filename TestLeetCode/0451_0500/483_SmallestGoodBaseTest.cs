using leetCode._0451_0500;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _483_SmallestGoodBaseTest
    {
        _483_SmallestGoodBaseAlg alg = new _483_SmallestGoodBaseAlg();
        
        [TestMethod]
        public void TestCase01()
        {
            string n = "13";
            string exp = "3";
            string res = alg.SmallestGoodBase(n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string n = "4681";
            string exp = "8";
            string res = alg.SmallestGoodBase(n);
            Assert.AreEqual(exp, res);
        }
    }
}
