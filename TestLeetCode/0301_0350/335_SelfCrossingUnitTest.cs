using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _335_SelfCrossingUnitTest
    {
        _335_SelfCrossingAlg alg = new _335_SelfCrossingAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] distance = [2, 1, 1, 2];
            bool exp = true;
            bool res = alg.IsSelfCrossing(distance);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] distance = [1, 2, 3, 4];
            bool exp = false;
            bool res = alg.IsSelfCrossing(distance);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] distance = [1, 1, 1, 1];
            bool exp = true;
            bool res = alg.IsSelfCrossing(distance);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] distance = [1, 1, 2, 1, 1];
            bool exp = true;
            bool res = alg.IsSelfCrossing(distance);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] distance = [1, 1, 2, 2, 1, 1];
            bool exp = true;
            bool res = alg.IsSelfCrossing(distance);
            Assert.AreEqual(exp, res);
        }
    }
}
