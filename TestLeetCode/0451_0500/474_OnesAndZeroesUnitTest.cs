using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
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

        [TestMethod]
        public void TestCase03()
        {
            string[] strs = ["10", "0001", "111001", "1", "0"];
            int m = 3, n = 4;
            int exp = 3;
            int res = alg.FindMaxForm(strs, m, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string[] strs = ["0", "11", "1000", "01", "0", "101", "1", "1", "1", "0", "0", "0", "0", "1", "0", "0110101", "0", "11", "01", "00", "01111", "0011", "1", "1000", "0", "11101", "1", "0", "10", "0111"];
            int m = 9, n = 80;
            int exp = 17;
            int res = alg.FindMaxForm(strs, m, n);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string[] strs = ["011", "1", "11", "0", "010", "1", "10", "1", "1", "0", "0",
                "0", "01111", "011", "11", "00", "11", "10", "1", "0", "0", "0", "0", "101", "001110", "1", "0", "1", "0", "0", "10", "00100", "0", "10", "1", "1", "1", "011", "11", "11", "10", "10",
                "0000", "01", "1", "10", "0"];
            int m = 44, n = 39;
            int exp = 45;
            int res = alg.FindMaxForm(strs, m, n);
            Assert.AreEqual(exp, res);
        }
    }
}
