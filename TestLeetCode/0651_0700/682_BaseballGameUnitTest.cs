using leetCode._0651_0700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0651_0700
{
    [TestClass]
    public class _682_BaseballGameUnitTest
    {
        _682_BaseballGameAlg alg = new _682_BaseballGameAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] ops = ["5", "2", "C", "D", "+"];
            int exp = 30;
            int res = alg.CalPoints(ops);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            string[] ops = ["5", "-2", "4", "C", "D", "9", "+", "+"];
            int exp = 27;
            int res = alg.CalPoints(ops);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            string[] ops = ["1"];
            int exp = 1;
            int res = alg.CalPoints(ops);
            Assert.AreEqual(exp, res);
        }
    }
}
