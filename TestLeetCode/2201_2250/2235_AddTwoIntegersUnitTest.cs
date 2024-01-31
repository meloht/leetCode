using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2201_2250
{
    [TestClass]
    public class _2235_AddTwoIntegersUnitTest
    {
        _2235_AddTwoIntegersAlg alg = new _2235_AddTwoIntegersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num1 = 12, num2 = 5;
            int exp = 17;
            int res = alg.Sum(num1, num2);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num1 = -10, num2 = 4;
            int exp = -6;
            int res = alg.Sum(num1, num2);
            Assert.AreEqual(exp, res);
        }
    }
}
