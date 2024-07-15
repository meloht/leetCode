using leetCode._3001_3050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3001_3050
{
    [TestClass]
    public class _3011_FindIfArrayCanBeSortedTest
    {
        _3011_FindIfArrayCanBeSortedAlg alg = new _3011_FindIfArrayCanBeSortedAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [8, 4, 2, 30, 15];
            bool exp = true;
            bool res = alg.CanSortArray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 4, 5];
            bool exp = true;
            bool res = alg.CanSortArray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [3, 16, 8, 4, 2];
            bool exp = false;
            bool res = alg.CanSortArray(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int aa = int.PopCount(4);
            int aa1=int.PopCount(3);
            int[] nums = [175, 231, 27, 92];
            bool exp = false;
            bool res = alg.CanSortArray(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
