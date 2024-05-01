using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _334_IncreasingTripletSubsequenceUnitTest
    {
        _334_IncreasingTripletSubsequenceAlg alg = new _334_IncreasingTripletSubsequenceAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] nums = [1, 2, 3, 4, 5];
            bool exp = true;
            bool res = alg.IncreasingTriplet(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] nums = [5, 4, 3, 2, 1];
            bool exp = false;
            bool res = alg.IncreasingTriplet(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] nums = [2, 1, 5, 0, 4, 6];
            bool exp = true;
            bool res = alg.IncreasingTriplet(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] nums = [20, 100, 10, 12, 5, 13];
            bool exp = true;
            bool res = alg.IncreasingTriplet(nums);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] nums = [1, 5, 0, 4, 1, 3];
            bool exp = true;
            bool res = alg.IncreasingTriplet(nums);
            Assert.AreEqual(exp, res);
        }
    }
}
