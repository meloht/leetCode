using leetCode._0201_0250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0201_0250
{
    [TestClass]
    public class _213_HouseRobberIIUnitTest
    {
        _213_HouseRobberIIAlg alg = new _213_HouseRobberIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [2, 3, 2];
            int exp = 3;
            int res = alg.Rob(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [1, 2, 3, 1];
            int exp = 4;
            int res = alg.Rob(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [1, 2, 3];
            int exp = 3;
            int res = alg.Rob(nums);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [0, 0, 0];
            int exp = 0;
            int res = alg.Rob(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [1, 1, 1];
            int exp = 1;
            int res = alg.Rob(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] nums = [1, 2, 1, 1];
            int exp = 3;
            int res = alg.Rob(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
