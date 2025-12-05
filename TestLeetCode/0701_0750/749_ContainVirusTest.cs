using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _749_ContainVirusTest
    {
        _749_ContainVirusAlg alg = new _749_ContainVirusAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] isInfected = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];
            int exp = 4;
            int res = alg.ContainVirus(isInfected);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[][] isInfected = [[1, 1, 1, 0, 0, 0, 0, 0, 0], [1, 0, 1, 0, 1, 1, 1, 1, 1], [1, 1, 1, 0, 0, 0, 0, 0, 0]];
            int exp = 13;
            int res = alg.ContainVirus(isInfected);
            Assert.AreEqual(exp, res);
        }
    }
}
