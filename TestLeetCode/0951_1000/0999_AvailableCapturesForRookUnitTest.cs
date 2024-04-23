using leetCode._0951_1000;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0951_1000
{
    [TestClass]
    public class _0999_AvailableCapturesForRookUnitTest
    {
        _0999_AvailableCapturesForRookAlg alg = new _0999_AvailableCapturesForRookAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[][] board = [
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', 'p', '.', '.', '.', '.'],
            ['.', '.', '.', 'R', '.', '.', '.', 'p'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', 'p', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.']];

            int exp = 3;
            int res = alg.NumRookCaptures(board);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase02()
        {
            char[][] board = [
            ['.', '.', '.', '.', '.', '.', '.', '.'], 
            ['.', 'p', 'p', 'p', 'p', 'p', '.', '.'], 
            ['.', 'p', 'p', 'B', 'p', 'p', '.', '.'], 
            ['.', 'p', 'B', 'R', 'B', 'p', '.', '.'], 
            ['.', 'p', 'p', 'B', 'p', 'p', '.', '.'], 
            ['.', 'p', 'p', 'p', 'p', 'p', '.', '.'], 
            ['.', '.', '.', '.', '.', '.', '.', '.'], 
            ['.', '.', '.', '.', '.', '.', '.', '.']];

            int exp = 0;
            int res = alg.NumRookCaptures(board);
            Assert.AreEqual(exp, res);

        }

        [TestMethod]
        public void TestCase03()
        {
            char[][] board = [
            ['.', '.', '.', '.', '.', '.', '.', '.'], 
            ['.', '.', '.', 'p', '.', '.', '.', '.'], 
            ['.', '.', '.', 'p', '.', '.', '.', '.'], 
            ['p', 'p', '.', 'R', '.', 'p', 'B', '.'], 
            ['.', '.', '.', '.', '.', '.', '.', '.'], 
            ['.', '.', '.', 'B', '.', '.', '.', '.'], 
            ['.', '.', '.', 'p', '.', '.', '.', '.'], 
            ['.', '.', '.', '.', '.', '.', '.', '.']];

            int exp = 3;
            int res = alg.NumRookCaptures(board);
            Assert.AreEqual(exp, res);

        }
    }
}
