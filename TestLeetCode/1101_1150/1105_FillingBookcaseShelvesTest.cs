using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1105_FillingBookcaseShelvesTest
    {
        _1105_FillingBookcaseShelvesAlg alg = new _1105_FillingBookcaseShelvesAlg();

        [TestMethod]
        public void Test01()
        {
            int[][] books = [[1, 1], [2, 3], [2, 3], [1, 1], [1, 1], [1, 1], [1, 2]];
            int shelfWidth = 4;
            int exp = 6;
            int res = alg.MinHeightShelves(books, shelfWidth);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[][] books = [[1, 3], [2, 4], [3, 2]];
            int shelfWidth = 6;
            int exp = 4;
            int res = alg.MinHeightShelves(books, shelfWidth);
            Assert.AreEqual(exp, res);
        }
    }
}
