using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1001_1050
{
    [TestClass]
    public class _1020_NumberOfEnclavesUnitTest
    {
        _1020_NumberOfEnclavesAlg alg = new _1020_NumberOfEnclavesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[][] grid = [[0, 0, 0, 0], [1, 0, 1, 0], [0, 1, 1, 0], [0, 0, 0, 0]];
            int exp = 3;
            int res = alg.NumEnclaves(grid);
            Assert.AreEqual(exp, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            int[][] grid = [[0, 1, 1, 0], [0, 0, 1, 0], [0, 0, 1, 0], [0, 0, 0, 0]];
            int exp = 0;
            int res = alg.NumEnclaves(grid);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] grid = [
                [0, 0, 0, 1, 1, 1, 0, 1, 0, 0], 
                [1, 1, 0, 0, 0, 1, 0, 1, 1, 1], 
                [0, 0, 0, 1, 1, 1, 0, 1, 0, 0], 
                [0, 1, 1, 0, 0, 0, 1, 0, 1, 0], 
                [0, 1, 1, 1, 1, 1, 0, 0, 1, 0], 
                [0, 0, 1, 0, 1, 1, 1, 1, 0, 1], 
                [0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 
                [0, 0, 1, 0, 0, 1, 0, 1, 0, 1], 
                [1, 0, 1, 0, 1, 1, 0, 0, 0, 0], 
                [0, 0, 0, 0, 1, 1, 0, 0, 0, 1]];
            int exp =3;
            int res = alg.NumEnclaves(grid);
            Assert.AreEqual(exp, res);
        }
    }
}
