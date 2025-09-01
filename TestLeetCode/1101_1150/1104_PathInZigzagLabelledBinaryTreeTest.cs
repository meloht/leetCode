using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1104_PathInZigzagLabelledBinaryTreeTest
    {
        _1104_PathInZigzagLabelledBinaryTreeAlg alg = new _1104_PathInZigzagLabelledBinaryTreeAlg();

        [TestMethod]
        public void Test01()
        {
            int label = 14;
            int[] exp = [1, 3, 4, 14];
            int[] res = alg.PathInZigZagTree(label).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void Test02()
        {
            int label = 26;
            int[] exp = [1, 2, 6, 10, 26];
            int[] res = alg.PathInZigZagTree(label).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
