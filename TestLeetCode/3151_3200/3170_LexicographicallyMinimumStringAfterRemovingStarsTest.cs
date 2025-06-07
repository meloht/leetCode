using leetCode._3151_3200;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3151_3200
{
    [TestClass]
    public class _3170_LexicographicallyMinimumStringAfterRemovingStarsTest
    {
        _3170_LexicographicallyMinimumStringAfterRemovingStarsAlg alg = new _3170_LexicographicallyMinimumStringAfterRemovingStarsAlg();

        [TestMethod]
        public void Test01()
        {
            string s = "aaba*";
            string exp = "aab";
            string res = alg.ClearStars(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            string s = "abc";
            string exp = "abc";
            string res = alg.ClearStars(s);
            Assert.AreEqual(exp, res);
        }
    }
}
