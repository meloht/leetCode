using leetCode._1651_1700;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1651_1700
{
    [TestClass]
    public class _1652_DefuseTheBombUnitTest
    {
        _1652_DefuseTheBombAlg alg = new _1652_DefuseTheBombAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] code = [5, 7, 1, 4];
            int k = 3;
            int[] exp = [12, 10, 16, 13];
            int[] res = alg.Decrypt(code, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] code = [1, 2, 3, 4];
            int k = 0;
            int[] exp = [0, 0, 0, 0];
            int[] res = alg.Decrypt(code, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] code = [2, 4, 9, 3];
            int k = -2;
            int[] exp = [12, 5, 6, 13];
            int[] res = alg.Decrypt(code, k);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
