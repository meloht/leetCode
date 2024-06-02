using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1521_FindAValueOfAMysteriousFunctionClosestToTargetUnitTest
    {
        _1521_FindAValueOfAMysteriousFunctionClosestToTargetAlg alg = new _1521_FindAValueOfAMysteriousFunctionClosestToTargetAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [9, 12, 3, 7, 15];
            int target = 5;
            int exp = 2;
            int res = alg.ClosestToTarget(arr, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1000000, 1000000, 1000000];
            int target = 1;
            int exp = 999999;
            int res = alg.ClosestToTarget(arr, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [1, 2, 4, 8, 16];
            int target = 0;
            int exp = 0;
            int res = alg.ClosestToTarget(arr, target);
            Assert.AreEqual(exp, res);
        }
    }
}
