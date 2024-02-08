using leetCode._0401_0450;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _433_MinimumGeneticMutationUnitTest
    {
        _433_MinimumGeneticMutationAlg alg = new _433_MinimumGeneticMutationAlg();

        [TestMethod]
        public void TestCase01()
        {
            string start = "AACCGGTT", end = "AACCGGTA";
            string[] bank = ["AACCGGTA"];
            int exp = 1;
            int res = alg.MinMutation(start, end, bank);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string start = "AACCGGTT", end = "AAACGGTA";
            string[] bank = ["AACCGGTA", "AACCGCTA", "AAACGGTA"];
            int exp = 2;
            int res = alg.MinMutation(start, end, bank);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string start = "AAAAACCC", end = "AACCCCCC";
            string[] bank = ["AAAACCCC", "AAACCCCC", "AACCCCCC"];
            int exp = 3;
            int res = alg.MinMutation(start, end, bank);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string start = "AACCTTGG", end = "AATTCCGG";
            string[] bank = ["AATTCCGG", "AACCTGGG", "AACCCCGG", "AACCTACC"];
            int exp = -1;
            int res = alg.MinMutation(start, end, bank);
            Assert.AreEqual(exp, res);
        }
    }
}
