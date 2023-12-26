using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0051_0100
{
    [TestClass]
    public class _70_ClimbingStairsUnitTest
    {
        _70_ClimbingStairsAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _70_ClimbingStairsAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int res = alg.ClimbStairs(2);
            int exp = 2;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int res = alg.ClimbStairs(3);
            int exp = 3;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int res = alg.ClimbStairs(4);
            int exp = 5;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int res = alg.ClimbStairs(5);
            int exp = 8;
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int res = alg.ClimbStairs(6);
            int exp = 13;
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            int res = alg.ClimbStairs(45);

        }
    }
}
