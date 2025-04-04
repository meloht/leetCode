using leetCode._0851_0900;
using leetCode.WeeklyContest._0401;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _890_FindAndReplacePatternTest
    {
        _890_FindAndReplacePatternAlg alg = new _890_FindAndReplacePatternAlg();
        [Fact]
        public void Test01()
        {
            string[] words = ["abc", "deq", "mee", "aqq", "dkd", "ccc"];
            string pattern = "abb";
            string[] exp = ["mee", "aqq"];
            string[] res = alg.FindAndReplacePattern(words, pattern).ToArray();
            Assert.Equal(exp, res);
        }


    }
}
