using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3206_AlternatingGroupsITest
    {
        _3206_AlternatingGroupsIAlg alg = new _3206_AlternatingGroupsIAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] colors = [1, 1, 1];
            int exp = 0;
            int res = alg.NumberOfAlternatingGroups(colors);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] colors = [0, 1, 0, 0, 1];
            int exp = 3;
            int res = alg.NumberOfAlternatingGroups(colors);
            Assert.AreEqual(exp, res);
        }

      
    }
}
