using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _717_1BitAnd2BitCharactersUnitTest
    {
        _717_1BitAnd2BitCharactersAlg alg = new _717_1BitAnd2BitCharactersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] bits = [1, 0, 0];
            bool exp = true;
            bool res = alg.IsOneBitCharacter(bits);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] bits = [1, 1, 1, 0];
            bool exp = false;
            bool res = alg.IsOneBitCharacter(bits);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] bits = [0, 1, 0];
            bool exp = false;
            bool res = alg.IsOneBitCharacter(bits);
            Assert.AreEqual(exp, res);
        }
    }
}
