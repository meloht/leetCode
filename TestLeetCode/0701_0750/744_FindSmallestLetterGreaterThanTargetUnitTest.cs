using leetCode._0701_0750;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0701_0750
{
    [TestClass]
    public class _744_FindSmallestLetterGreaterThanTargetUnitTest
    {
        _744_FindSmallestLetterGreaterThanTargetAlg alg = new _744_FindSmallestLetterGreaterThanTargetAlg();

        [TestMethod]
        public void TestCase01()
        {
            char[] letters = ['c', 'f', 'j'];
            char target = 'a';
            char exp = 'c';
            char res = alg.NextGreatestLetter(letters, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            char[] letters = ['c', 'f', 'j'];
            char target = 'c';
            char exp = 'f';
            char res = alg.NextGreatestLetter(letters, target);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            char[] letters = ['x', 'x', 'y', 'y'];
            char target = 'z';
            char exp = 'x';
            char res = alg.NextGreatestLetter(letters, target);
            Assert.AreEqual(exp, res);
        }
    }
}
