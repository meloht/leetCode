using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _846_HandOfStraightsTest
    {
        _846_HandOfStraightsAlg alg = new _846_HandOfStraightsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] hand = [1, 2, 3, 6, 2, 3, 4, 7, 8];
            int groupSize = 3;
            bool exp = true;
            bool res = alg.IsNStraightHand(hand, groupSize);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] hand = [1, 2, 3, 4, 5];
            int groupSize = 4;
            bool exp = false;
            bool res = alg.IsNStraightHand(hand, groupSize);
            Assert.AreEqual(exp, res);
        }
    }
}
