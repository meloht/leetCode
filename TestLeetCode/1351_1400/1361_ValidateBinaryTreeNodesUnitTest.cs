using leetCode._1351_1400;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1351_1400
{
    [TestClass]
    public class _1361_ValidateBinaryTreeNodesUnitTest
    {
        _1361_ValidateBinaryTreeNodesAlg alg = new _1361_ValidateBinaryTreeNodesAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] leftChild = [1, -1, 3, -1], rightChild = [2, -1, -1, -1];
            int n = 4;
            bool exp = true;
            bool res = alg.ValidateBinaryTreeNodes(n, leftChild, rightChild);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] leftChild = [1, -1, 3, -1], rightChild = [2, 3, -1, -1];
            int n = 4;
            bool exp = false;
            bool res = alg.ValidateBinaryTreeNodes(n, leftChild, rightChild);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] leftChild = [1, 0], rightChild = [-1, -1];
            int n = 2;
            bool exp = false;
            bool res = alg.ValidateBinaryTreeNodes(n, leftChild, rightChild);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            int[] leftChild = [1, -1, -1, 4, -1, -1], rightChild = [2, -1, -1, 5, -1, -1];
            int n = 6;
            bool exp = false;
            bool res = alg.ValidateBinaryTreeNodes(n, leftChild, rightChild);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            int[] leftChild = [3, -1, 1, -1], rightChild = [-1, -1, 0, -1];
            int n = 4;
            bool exp = true;
            bool res = alg.ValidateBinaryTreeNodes(n, leftChild, rightChild);
            Assert.AreEqual(exp, res);
        }
    }
}
