using leetCode._3101_3150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3101_3150
{
    [TestClass]
    public class _3144_MinimumSubstringPartitionOfEqualCharacterFrequencyTest
    {
        _3144_MinimumSubstringPartitionOfEqualCharacterFrequencyAlg alg = new _3144_MinimumSubstringPartitionOfEqualCharacterFrequencyAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "fabccddg";
            int exp = 3;
            int res = alg.MinimumSubstringsInPartition(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abababaccddb";
            int exp = 2;
            int res = alg.MinimumSubstringsInPartition(s);
            Assert.AreEqual(exp, res);
        }
    }
}
