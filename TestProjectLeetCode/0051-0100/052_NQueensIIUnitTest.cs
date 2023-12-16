using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._51_100
{
    [TestClass]
    public class _52_NQueensIIUnitTest
    {
        _52_NQueensIIAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _52_NQueensIIAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.TotalNQueens(4);

            Assert.AreEqual(2, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            var res = alg.TotalNQueens(1);

            Assert.AreEqual(1, res);
        }
    }
}
