using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _769_MaxChunksToMakeSortedTest
    {
        _769_MaxChunksToMakeSortedAlg alg = new _769_MaxChunksToMakeSortedAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = [4, 3, 2, 1, 0];
            int exp = 1;
            int res = alg.MaxChunksToSorted(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = [1, 0, 2, 3, 4];
            int exp = 4;
            int res = alg.MaxChunksToSorted(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = [2, 0, 1];
            int exp = 1;
            int res = alg.MaxChunksToSorted(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] arr = [1, 2, 0, 3];
            int exp = 2;
            int res = alg.MaxChunksToSorted(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] arr = [1, 2, 3, 0];
            int exp = 1;
            int res = alg.MaxChunksToSorted(arr);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            int[] arr = [0, 2, 1];
            int exp = 2;
            int res = alg.MaxChunksToSorted(arr);
            Assert.AreEqual(exp, res);
        }
    }
}
