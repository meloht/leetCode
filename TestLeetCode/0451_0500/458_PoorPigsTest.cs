using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _458_PoorPigsTest
    {
        _458_PoorPigsAlg alg = new _458_PoorPigsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int buckets = 1000, minutesToDie = 15, minutesToTest = 60;
            int exp = 5;
            int res = alg.PoorPigs(buckets, minutesToDie, minutesToTest);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int buckets = 4, minutesToDie = 15, minutesToTest = 15;
            int exp = 2;
            int res = alg.PoorPigs(buckets, minutesToDie, minutesToTest);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int buckets = 4, minutesToDie = 15, minutesToTest = 30;
            int exp = 2;
            int res = alg.PoorPigs(buckets, minutesToDie, minutesToTest);
            Assert.AreEqual(exp, res);
        }
    }
}
