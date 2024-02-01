using leetCode._1_50;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0001_0050
{
    [TestClass]
    public class _31_NextPermutationUnitTest
    {
        private readonly NextPermutationAlg nextPermutationAlg = new();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 1, 3, 2 };

            nextPermutationAlg.NextPermutation(nums1);
           

            Assert.IsTrue(nums1.SequenceEqual(nums2));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums1 = { 3, 2, 1 };
            int[] nums2 = { 1, 2, 3 };

            nextPermutationAlg.NextPermutation(nums1);


            Assert.IsTrue(nums1.SequenceEqual(nums2));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums1 = { 1, 1, 5 };
            int[] nums2 = { 1, 5, 1 };

            nextPermutationAlg.NextPermutation(nums1);


            Assert.IsTrue(nums1.SequenceEqual(nums2));
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums1 = { 1, 3, 2 };
            int[] nums2 = { 2, 1, 3 };

           
            nextPermutationAlg.NextPermutation(nums1);

            Assert.IsTrue(nums1.SequenceEqual(nums2));
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums1 = { 2, 3, 1 };
            int[] nums2 = { 3, 1, 2 };

            nextPermutationAlg.NextPermutation(nums1);

            Assert.IsTrue(nums1.SequenceEqual(nums2));
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] nums1 = { 5, 4, 7, 5, 3, 2 };
            int[] nums2 = { 5, 5, 2, 3, 4, 7 };

            nextPermutationAlg.NextPermutation(nums1);

            Assert.IsTrue(nums1.SequenceEqual(nums2));
        }

        //4,2,0,2,3,2,0

        [TestMethod]
        public void TestCase07()
        {
            int[] nums1 = { 4, 2, 0, 2, 3, 2, 0 };
            int[] nums2 = { 4, 2, 0, 3, 0, 2, 2 };

            nextPermutationAlg.NextPermutation(nums1);

            Assert.IsTrue(nums1.SequenceEqual(nums2));
        }
    }
}
