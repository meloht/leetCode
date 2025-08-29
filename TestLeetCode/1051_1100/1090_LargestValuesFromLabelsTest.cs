using leetCode._1051_1100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1051_1100
{
    [TestClass]
    public class _1090_LargestValuesFromLabelsTest
    {
        _1090_LargestValuesFromLabelsAlg alg = new _1090_LargestValuesFromLabelsAlg();

        [TestMethod]
        public void Test01()
        {
            int[] values = [5, 4, 3, 2, 1], labels = [1, 1, 2, 2, 3];
            int numWanted = 3, useLimit = 1;
            int exp = 9;
            int res = alg.LargestValsFromLabels(values, labels, numWanted, useLimit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            int[] values = [5, 4, 3, 2, 1], labels = [1, 3, 3, 3, 2];
            int numWanted = 3, useLimit = 2;
            int exp = 12;
            int res = alg.LargestValsFromLabels(values, labels, numWanted, useLimit);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test03()
        {
            int[] values = [9, 8, 8, 7, 6], labels = [0, 0, 0, 1, 1];
            int numWanted = 3, useLimit = 1;
            int exp = 16;
            int res = alg.LargestValsFromLabels(values, labels, numWanted, useLimit);
            Assert.AreEqual(exp, res);
        }

    }
}
