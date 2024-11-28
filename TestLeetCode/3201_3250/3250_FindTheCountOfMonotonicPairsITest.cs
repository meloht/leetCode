using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3250_FindTheCountOfMonotonicPairsITest
    {
        _3250_FindTheCountOfMonotonicPairsIAlg alg = new _3250_FindTheCountOfMonotonicPairsIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 3, 2];
            int exp = 4;
            int res = alg.CountOfPairs(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [5, 5, 5, 5];
            int exp = 126;
            int res = alg.CountOfPairs(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
