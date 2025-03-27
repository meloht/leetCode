using leetCode._2701_2750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2701_2750
{
    [TestClass]
    public class _2712_MinimumCostToMakeAllCharactersEqualTest
    {
        _2712_MinimumCostToMakeAllCharactersEqualAlg alg = new _2712_MinimumCostToMakeAllCharactersEqualAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "0011";
            long exp = 2;
            long res = alg.MinimumCost(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "010101";
            long exp = 9;
            long res = alg.MinimumCost(s);
            Assert.AreEqual(exp, res);
        }
    }
}
