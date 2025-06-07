using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3193_CountTheNumberOfInversionsTest
    {
        _3193_CountTheNumberOfInversionsAlg alg = new _3193_CountTheNumberOfInversionsAlg();

        [TestMethod]
        public void TestCase01()
        {
            int n = 3;
            int[][] requirements = [[2, 2], [0, 0]];
            int exp = 2;
            int res = alg.NumberOfPermutations(n, requirements);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int n = 3;
            int[][] requirements = [[2, 2], [1, 1], [0, 0]];
            int exp = 1;
            int res = alg.NumberOfPermutations(n, requirements);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int n = 2;
            int[][] requirements = [[0, 0], [1, 0]];
            int exp = 1;
            int res = alg.NumberOfPermutations(n, requirements);
            Assert.AreEqual(exp, res);
        }

    }
}
