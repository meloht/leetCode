using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _62_UniquePathsUnitTest
    {
        _62_UniquePathsAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _62_UniquePathsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.UniquePaths(3, 7);
            Assert.AreEqual(28, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.UniquePaths(3, 2);
            Assert.AreEqual(3, res);
        }
    }
}
