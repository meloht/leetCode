using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _457_CircularArrayLoopTest
    {
        _457_CircularArrayLoopAlg alg = new _457_CircularArrayLoopAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, -1, 1, 2, 2];
            bool exp = true;
            bool res = alg.CircularArrayLoop(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [-1, 2];
            bool exp = false;
            bool res = alg.CircularArrayLoop(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [-2, 1, -1, -2, -2];
            bool exp = false;
            bool res = alg.CircularArrayLoop(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [1, -1, 5, 1, 4];
            bool exp = true;
            bool res = alg.CircularArrayLoop(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [1, 2, 3, 4, 5];
            bool exp = true;
            bool res = alg.CircularArrayLoop(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
