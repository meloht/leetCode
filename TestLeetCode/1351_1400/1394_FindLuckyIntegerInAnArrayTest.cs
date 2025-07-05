using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1394_FindLuckyIntegerInAnArrayTest
    {
        _1394_FindLuckyIntegerInAnArrayAlg alg = new _1394_FindLuckyIntegerInAnArrayAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [2, 2, 3, 4];
            int exp = 2;
            int res = alg.FindLucky(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 2, 2, 3, 3, 3];
            int exp = 3;
            int res = alg.FindLucky(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [2, 2, 2, 3, 3];
            int exp = 1;
            int res = alg.FindLucky(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] arr = [5];
            int exp = -1;
            int res = alg.FindLucky(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] arr = [7, 7, 7, 7, 7, 7, 7];
            int exp = 7;
            int res = alg.FindLucky(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
