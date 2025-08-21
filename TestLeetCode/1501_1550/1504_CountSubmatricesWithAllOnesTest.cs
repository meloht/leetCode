using leetCode._1501_1550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1501_1550
{
    [TestClass]
    public class _1504_CountSubmatricesWithAllOnesTest
    {
        _1504_CountSubmatricesWithAllOnesAlg alg = new _1504_CountSubmatricesWithAllOnesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] mat = [[1, 0, 1], [1, 1, 0], [1, 1, 0]];
            int exp = 13;
            int res = alg.NumSubmat(mat);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[][] mat = [[0, 1, 1, 0], [0, 1, 1, 1], [1, 1, 1, 0]];
            int exp = 24;
            int res = alg.NumSubmat(mat);
            Assert.AreEqual(exp, res);
        }
    }
}
