using leetCode._1401_1450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1401_1450
{
    [TestClass]
    public class _1432_MaxDifferenceYouCanGetFromChangingAnIntegerTest
    {
        _1432_MaxDifferenceYouCanGetFromChangingAnIntegerAlg alg = new _1432_MaxDifferenceYouCanGetFromChangingAnIntegerAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 555;
            int exp = 888;
            int res = alg.MaxDiff(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 9;
            int exp = 8;
            int res = alg.MaxDiff(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int num = 123456;
            int exp = 820000;
            int res = alg.MaxDiff(num);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int num = 10000;
            int exp = 80000;
            int res = alg.MaxDiff(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int num = 9288;
            int exp = 8700;
            int res = alg.MaxDiff(num);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int num = 1101057;
            int exp = 8808050;
            int res = alg.MaxDiff(num);
            Assert.AreEqual(exp, res);
        }
    }
}
