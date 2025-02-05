using leetCode._0751_0800;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0751_0800
{
    [TestClass]
    public class _784_LetterCasePermutationTest
    {
        _784_LetterCasePermutationAlg alg=new _784_LetterCasePermutationAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "a1b2";
            List<string> exp = new List<string> { "a1b2", "A1b2", "a1B2", "A1B2" };
            IList<string> res = alg.LetterCasePermutation(s);
            CollectionAssert.AreEqual(exp, res.ToList());
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "3z4";
            List<string> exp = ["3z4", "3Z4"];
            IList<string> res = alg.LetterCasePermutation(s);
            CollectionAssert.AreEqual(exp, res.ToList());
        }
    }
}
