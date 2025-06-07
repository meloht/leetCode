using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3200_MaximumHeightOfATriangleTest
    {
        _3200_MaximumHeightOfATriangleAlg alg = new _3200_MaximumHeightOfATriangleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int red = 2, blue = 4;
            int exp = 3;
            int res = alg.MaxHeightOfTriangle(red, blue);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int red = 2, blue = 1;
            int exp = 2;
            int res = alg.MaxHeightOfTriangle(red, blue);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int red = 1, blue = 1;
            int exp = 1;
            int res = alg.MaxHeightOfTriangle(red, blue);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            int red = 10, blue = 1;
            int exp = 2;
            int res = alg.MaxHeightOfTriangle(red, blue);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int red = 9, blue = 3;
            int exp = 3;
            int res = alg.MaxHeightOfTriangle(red, blue);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int red = 10, blue = 10;
            int exp = 5;
            int res = alg.MaxHeightOfTriangle(red, blue);
            Assert.AreEqual(exp, res);
        }
    }
}
