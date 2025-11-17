using leetCode._1401_1450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1401_1450
{
    [TestClass]
    public class _1437_CheckIfAll1sAreAtLeastLengthkPlacesAwayTest
    {
        _1437_CheckIfAll1sAreAtLeastLengthkPlacesAwayAlg alg = new _1437_CheckIfAll1sAreAtLeastLengthkPlacesAwayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 0, 0, 0, 1, 0, 0, 1];
            int k = 2;
            bool exp = true;
            bool res = alg.KLengthApart(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 0, 0, 1, 0, 1];
            int k = 2;
            bool exp = false;
            bool res = alg.KLengthApart(nums, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [0, 1, 0, 0, 1, 0, 0, 1];
            int k = 2;
            bool exp = true;
            bool res = alg.KLengthApart(nums, k);
            Assert.AreEqual(exp, res);
        }
    }
}
