using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _115_DistinctSubsequencesUnitTest
    {
        _115_DistinctSubsequencesAlg alg = new _115_DistinctSubsequencesAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "rabbbit";
            string t = "rabbit";
            int num = alg.NumDistinct(s, t);

            Assert.AreEqual(num, 3);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "babgbag";
            string t = "bag";
            int num = alg.NumDistinct(s, t);

            Assert.AreEqual(num, 5);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "eee";
            string t = "eee";
            int num = alg.NumDistinct(s, t);

            Assert.AreEqual(num, 1);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "aabb";
            string t = "abb";
            int num = alg.NumDistinct(s, t);

            Assert.AreEqual(num, 2);
        }

        [TestMethod]
        public void TestCase05()
        {
            string s = "adbdadeecadeadeccaeaabdabdbcdabddddabcaaadbabaaedeeddeaeebcdeabcaaaeeaeeabcddcebddebeebedaecccbdcbcedbdaeaedcdebeecdaaedaacadbdccabddaddacdddc";
            string t = "bcddceeeebecbc";
            int num = alg.NumDistinct(s, t);
            Assert.AreEqual(700531452, num);

        }
    }
}
