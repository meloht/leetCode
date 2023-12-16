using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _88_MergeSortedArrayUnitTest
    {
        _88_MergeSortedArrayAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _88_MergeSortedArrayAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };

            //alg.Move(2, nums1, 2);
            int m = 3;
            int[] num2 = { 2, 5, 6 };
            int n = 3;
            alg.Merge(nums1, m, num2, n);
            int[] exp = { 1, 2, 2, 3, 5, 6 };
            bool bl = exp.SequenceEqual(nums1);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = { 1 };
            int m = 1;
            int[] num2 = { };
            int n = 0;
            alg.Merge(nums1, m, num2, n);
            int[] exp = { 1 };
            bool bl = exp.SequenceEqual(nums1);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums1 = { 0 };
            int m = 0;
            int[] num2 = { 1 };
            int n = 1;
            alg.Merge(nums1, m, num2, n);
            int[] exp = { 1 };
            bool bl = exp.SequenceEqual(nums1);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums1 = { 2, 0 };
            int m = 1;
            int[] num2 = { 1 };
            int n = 1;
            alg.Merge(nums1, m, num2, n);
            int[] exp = { 1,2 };
            bool bl = exp.SequenceEqual(nums1);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums1 = { 0, 0, 0, 0, 0 };
            int m = 0;
            int[] num2 = { 1, 2, 3, 4, 5 };
            int n =5;
            alg.Merge(nums1, m, num2, n);
            int[] exp = { 1, 2, 3, 4, 5 };
            bool bl = exp.SequenceEqual(nums1);
            Assert.AreEqual(true, bl);
        }
    }
}
