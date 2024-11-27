using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3208_AlternatingGroupsIITest
    {
        _3208_AlternatingGroupsIIAlg alg = new _3208_AlternatingGroupsIIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] colors = [0, 1, 0, 1, 0];
            int k = 3;
            int exp = 3;
            int res = alg.NumberOfAlternatingGroups(colors, k);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] colors = [0, 1, 0, 0, 1, 0, 1];
            int k = 6;
            int exp = 2;
            int res = alg.NumberOfAlternatingGroups(colors, k);
            Assert.AreEqual(exp, res);
        }
        [TestMethod]
        public void TestCase03()
        {
            int[] colors = [1, 1, 0, 1];
            int k = 4;
            int exp = 0;
            int res = alg.NumberOfAlternatingGroups(colors, k);
            Assert.AreEqual(exp, res);
        }
    }
}
