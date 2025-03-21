using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _823_BinaryTreesWithFactorsTest
    {
        _823_BinaryTreesWithFactorsAlg alg = new _823_BinaryTreesWithFactorsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [2, 4];
            int exp = 3;
            int res = alg.NumFactoredBinaryTrees(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [2, 4, 5, 10];
            int exp = 7;
            int res = alg.NumFactoredBinaryTrees(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
