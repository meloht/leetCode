using leetCode._1551_1600;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1551_1600
{
    [TestClass]
    public class _1578_MinimumTimeToMakeRopeColorfulTest
    {
        _1578_MinimumTimeToMakeRopeColorfulAlg alg = new _1578_MinimumTimeToMakeRopeColorfulAlg();


        [TestMethod]
        public void TestCase01()
        {
            string colors = "abaac";
            int[] neededTime = [1, 2, 3, 4, 5];
            int exp = 3;
            int res = alg.MinCost(colors, neededTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string colors = "abc";
            int[] neededTime = [1, 2, 3];
            int exp = 0;
            int res = alg.MinCost(colors, neededTime);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string colors = "aabaa";
            int[] neededTime = [1, 2, 3, 4, 1];
            int exp = 2;
            int res = alg.MinCost(colors, neededTime);
            Assert.AreEqual(exp, res);
        }
    }
}
