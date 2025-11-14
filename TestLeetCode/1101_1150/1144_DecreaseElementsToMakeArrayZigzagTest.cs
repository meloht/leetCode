using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1144_DecreaseElementsToMakeArrayZigzagTest
    {
        _1144_DecreaseElementsToMakeArrayZigzagAlg alg = new _1144_DecreaseElementsToMakeArrayZigzagAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3];
            int exp = 2;
            int res = alg.MovesToMakeZigzag(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [9, 6, 1, 6, 2];
            int exp = 4;
            int res = alg.MovesToMakeZigzag(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
