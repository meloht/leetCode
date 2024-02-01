using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _763_PartitionLabelsUnitTest
    {
        _763_PartitionLabelsAlg alg = new _763_PartitionLabelsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "ababcbacadefegdehijhklij";
            int[] exp = [9, 7, 8];
            int[] res = alg.PartitionLabels(s).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "eccbbbbdec";
            int[] exp = [10];
            int[] res = alg.PartitionLabels(s).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
