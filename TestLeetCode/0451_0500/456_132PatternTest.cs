using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _456_132PatternTest
    {
        _456_132PatternAlg alg = new _456_132PatternAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4];
            bool exp = false;
            bool res = alg.Find132pattern(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [3, 1, 4, 2];
            bool exp = true;
            bool res = alg.Find132pattern(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [-1, 3, 2, 0];
            bool exp = true;
            bool res = alg.Find132pattern(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [1, 0, 1, -4, -3];
            bool exp = false;
            bool res = alg.Find132pattern(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [1, 3, 2, 4, 5, 6, 7, 8, 9, 10];
            bool exp = true;
            bool res = alg.Find132pattern(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] nums = [3, 5, 0, 3, 4];
            bool exp = true;
            bool res = alg.Find132pattern(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase07()
        {
            int[] nums = [-2, 1, 2, -2, 1, 2];
            bool exp = true;
            bool res = alg.Find132pattern(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase08()
        {
            int[] nums = [2, 3, 1, 2];
            bool exp = false;
            bool res = alg.Find132pattern(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
