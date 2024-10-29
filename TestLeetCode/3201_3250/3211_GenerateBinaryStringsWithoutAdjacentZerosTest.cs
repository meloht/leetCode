using leetCode._3201_3250;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3211_GenerateBinaryStringsWithoutAdjacentZerosTest
    {
        _3211_GenerateBinaryStringsWithoutAdjacentZerosAlg alg = new _3211_GenerateBinaryStringsWithoutAdjacentZerosAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            IList<string> exp = ["010", "011", "101", "110", "111"];
            IList<string> res = alg.ValidStrings(n);

            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 1;
            IList<string> exp = ["0", "1"];
            IList<string> res = alg.ValidStrings(n);

            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
