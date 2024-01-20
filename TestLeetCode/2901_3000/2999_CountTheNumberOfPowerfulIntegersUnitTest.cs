using leetCode._2901_3000;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._2901_3000
{
    [TestClass]
    public class _2999_CountTheNumberOfPowerfulIntegersUnitTest
    {
        _2999_CountTheNumberOfPowerfulIntegersAlg alg = new _2999_CountTheNumberOfPowerfulIntegersAlg();

        [TestMethod]
        public void TestCase01()
        {
            long start = 1, finish = 6000;
            int limit = 4;
            string s = "124";
            int exp = 5;
            long res = alg.NumberOfPowerfulInt(start, finish, limit, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            long start = 15, finish = 215;
            int limit = 6;
            string s = "10";
            int exp = 2;
            long res = alg.NumberOfPowerfulInt(start, finish, limit, s);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase03()
        {
            long start = 1000, finish = 2000;
            int limit = 4;
            string s = "3000";
            int exp = 0;
            long res = alg.NumberOfPowerfulInt(start, finish, limit, s);
            Assert.AreEqual(exp, res);
        }
    }
}
