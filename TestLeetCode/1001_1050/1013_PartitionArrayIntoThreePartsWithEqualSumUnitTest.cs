using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1013_PartitionArrayIntoThreePartsWithEqualSumUnitTest
    {
        _1013_PartitionArrayIntoThreePartsWithEqualSumAlg alg = new _1013_PartitionArrayIntoThreePartsWithEqualSumAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1];
            bool exp = true;
            bool res=alg.CanThreePartsEqualSum(arr);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1];
            bool exp = false;
            bool res = alg.CanThreePartsEqualSum(arr);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [3, 3, 6, 5, -2, 2, 5, 1, -9, 4];
            bool exp = true;
            bool res = alg.CanThreePartsEqualSum(arr);
            Assert.AreEqual(exp, res);

        }
    }
}
