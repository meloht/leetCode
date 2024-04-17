using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _771_JewelsAndStonesUnitTest
    {
        _771_JewelsAndStonesAlg alg = new _771_JewelsAndStonesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string jewels = "aA", stones = "aAAbbbb";
            int exp = 3;
            int res = alg.NumJewelsInStones(jewels, stones);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string jewels = "z", stones = "ZZ";
            int exp = 0;
            int res = alg.NumJewelsInStones(jewels, stones);
            Assert.AreEqual(exp, res);
        }
    }
}
