using leetCodeTemplates.BinarySearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTest
{
    [TestClass]
    public class BinarySearchTemplateUnitTest
    {
        BinarySearchTemplate alg = new BinarySearchTemplate();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            int exp = 6;
            int res = alg.BinarySearchLeft(nums, 5);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3,  5, 6, 7, 8, 9];
            int exp = 6;
            int res = alg.BinarySearchLeft(nums, 5);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {

            int[] nums = [1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 8, 9];
            int exp = 6;
            int res = alg.BinarySearchLeft(nums, 5);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {

            int[] nums = [1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 8, 9];
            int exp = 5;
            int res = alg.BinarySearchLeft(nums, 4);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase05()
        {

            int[] nums = [1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 8, 9];
            int exp = 7;
            int res = alg.BinarySearchLeft(nums, 6);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase06()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            int exp = 4;
            int res = alg.BinarySearchRight(nums, 5);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            int[] nums = [1, 2, 3, 5, 6, 7, 8, 9];
            int exp = 3;
            int res = alg.BinarySearchRight(nums, 5);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase08()
        {

            int[] nums = [1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 8, 9];
            int exp = 4;
            int res = alg.BinarySearchRight(nums, 5);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase09()
        {

            int[] nums = [1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 8, 9];
            int exp = 3;
            int res = alg.BinarySearchRight(nums, 4);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase10()
        {

            int[] nums = [1, 2, 3, 4, 5, 5, 5, 5, 6, 7, 8, 9];
            int exp = 5;
            int res = alg.BinarySearchRight(nums, 6);
            Assert.AreEqual(exp, res);
        }
    }
}
