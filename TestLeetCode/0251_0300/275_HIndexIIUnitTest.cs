using leetCode._0251_0300;
using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _275_HIndexIIUnitTest
    {
        _275_HIndexIIAlg alg = new _275_HIndexIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] citations = [0, 1, 3, 5, 6];
            int exp = 3;
            int res = alg.HIndex(citations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] citations = [1, 2, 100];
            int exp = 2;
            int res = alg.HIndex(citations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] citations = [0];
            int exp = 0;
            int res = alg.HIndex(citations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] citations = [100];
            int exp = 1;
            int res = alg.HIndex(citations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] citations = [11, 15];
            int exp = 2;
            int res = alg.HIndex(citations);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] citations = [0, 0, 4, 4];
            int exp = 2;
            int res = alg.HIndex(citations);
            Assert.AreEqual(exp, res);
        }

    }
}
