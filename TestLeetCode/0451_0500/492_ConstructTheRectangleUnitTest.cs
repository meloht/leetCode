using leetCode._0451_0500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0451_0500
{
    [TestClass]
    public class _492_ConstructTheRectangleUnitTest
    {
        _492_ConstructTheRectangleAlg alg = new _492_ConstructTheRectangleAlg();

        [TestMethod]
        public void TestCase01()
        {
            int num = 4;
            int[] exp = [2, 2];
            int[] res = alg.ConstructRectangle(num);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int num = 37;
            int[] exp = [37, 1];
            int[] res = alg.ConstructRectangle(num);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int num = 122122;
            int[] exp = [427, 286];
            int[] res = alg.ConstructRectangle(num);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

    }
}
