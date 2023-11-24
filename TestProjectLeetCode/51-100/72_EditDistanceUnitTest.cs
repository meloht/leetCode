using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _72_EditDistanceUnitTest
    {
        _72_EditDistanceAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _72_EditDistanceAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.MinDistance("horse", "ros");
            var exp = 3;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.MinDistance("intention", "execution");
            var exp = 5;
            Assert.AreEqual(exp, res);
        }
    }
}
