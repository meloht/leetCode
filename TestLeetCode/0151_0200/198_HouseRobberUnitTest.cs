using leetCode._0151_0200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0151_0200
{
    [TestClass]
    public class _198_HouseRobberUnitTest
    {
        _198_HouseRobberAlg alg = new _198_HouseRobberAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 1];
            int res = alg.Rob(nums);
            Assert.AreEqual(4, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [2, 7, 9, 3, 1];
            int res = alg.Rob(nums);
            Assert.AreEqual(12, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [0];
            int res = alg.Rob(nums);
            Assert.AreEqual(0, res);
        }


        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [2, 1];
            int res = alg.Rob(nums);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [2, 1, 1, 2];
            int res = alg.Rob(nums);
            Assert.AreEqual(4, res);
        }
    }
}
