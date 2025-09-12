using leetCode._3201_3250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._3201_3250
{
    [TestClass]
    public class _3227_VowelsGameInAStringTest
    {
        _3227_VowelsGameInAStringAlg alg = new _3227_VowelsGameInAStringAlg();

        [TestMethod]
        public void Test01()
        {
            string s = "leetcoder";
            bool exp = true;
            bool res = alg.DoesAliceWin(s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void Test02()
        {
            string s = "bbcd";
            bool exp = false;
            bool res = alg.DoesAliceWin(s);
            Assert.AreEqual(exp, res);
        }
    }
}
