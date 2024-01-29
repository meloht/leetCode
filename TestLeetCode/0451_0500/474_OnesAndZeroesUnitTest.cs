using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0451_0500
{
    [TestClass]
    public class _474_OnesAndZeroesUnitTest
    {
        _474_OnesAndZeroesAlg alg = new _474_OnesAndZeroesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] strs = ["10", "0001", "111001", "1", "0"];
            int m = 5, n = 3;
            int exp = 4;
            int res = alg.FindMaxForm(strs, m, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] strs = ["10", "0", "1"];
            int m = 1, n = 1;
            int exp = 2;
            int res = alg.FindMaxForm(strs, m, n);
            Assert.AreEqual(exp, res);
        }
    }
}
