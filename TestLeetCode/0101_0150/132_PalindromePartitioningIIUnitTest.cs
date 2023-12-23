using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0101_0150
{
    [TestClass]
    public class _132_PalindromePartitioningIIUnitTest
    {
        _132_PalindromePartitioningIIAlg alg = new _132_PalindromePartitioningIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "aab";
            var res = alg.MinCut(s);

            Assert.AreEqual(res, 1);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "a";
            var res = alg.MinCut(s);

            Assert.AreEqual(res, 0);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "ab";
            var res = alg.MinCut(s);

            Assert.AreEqual(res, 1);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "cbbbcc";

            var res = alg.MinCut(s);
            Assert.AreEqual(res, 1);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "ssssssssssssss";
            var res = alg.MinCut(s);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void TestCase06()
        {
            string s = "aaabaa";
            var res = alg.MinCut(s);
            Assert.AreEqual(res, 1);
        }

        [TestMethod]
        public void TestCase07()
        {
            string s = "ccaacabacb";
            var res = alg.MinCut(s);
            Assert.AreEqual(res, 3);
        }

        [TestMethod]
        public void TestCase08()
        {
            string s = "fifgbeajcacehiicccfecbfhhgfiiecdcjjffbghdidbhbdbfbfjccgbbdcjheccfbhafehieabbdfeigbiaggchaeghaijfbjhi";
           
            var res = alg.MinCut(s);
            Assert.AreEqual(res, 75);
        }
    }
}
