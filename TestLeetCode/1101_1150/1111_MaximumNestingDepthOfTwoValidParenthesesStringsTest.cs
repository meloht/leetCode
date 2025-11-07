using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1111_MaximumNestingDepthOfTwoValidParenthesesStringsTest
    {
        _1111_MaximumNestingDepthOfTwoValidParenthesesStringsAlg alg = new _1111_MaximumNestingDepthOfTwoValidParenthesesStringsAlg();


        [TestMethod]
        public void TestCase01()
        {
            string seq = "(()())";
            int[] exp = [1, 0, 0, 0, 0, 1];
            int[] res = alg.MaxDepthAfterSplit(seq);
            Assert.IsTrue(exp.SequenceEqual(res));
        }

        [TestMethod]
        public void TestCase02()
        {
            string seq = "()(())()";
            int[] exp = [1, 1, 1, 0, 0, 1, 1, 1];
            int[] res = alg.MaxDepthAfterSplit(seq);
            Assert.IsTrue(exp.SequenceEqual(res));
        }
    }
}
