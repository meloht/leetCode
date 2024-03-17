using leetCode._0351_0400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0351_0400
{
    [TestClass]
    public class _354_RussianDollEnvelopesUnitTest
    {
        _354_RussianDollEnvelopesAlg alg = new _354_RussianDollEnvelopesAlg();
       
        [TestMethod]
        public void TestCase01()
        {
            int[][] envelopes = [[5, 4], [6, 4], [6, 7], [2, 3]];
            int exp = 3;
            int res = alg.MaxEnvelopes(envelopes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[][] envelopes = [[1, 1], [1, 1], [1, 1]];
            int exp = 1;
            int res = alg.MaxEnvelopes(envelopes);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[][] envelopes = [[2, 100], [3, 200], [4, 300], [5, 500], [5, 400], [5, 250], [6, 370], [6, 360], [7, 380]];
            int exp = 5;
            int res = alg.MaxEnvelopes(envelopes);
            Assert.AreEqual(exp, res);
        }
    }
}
