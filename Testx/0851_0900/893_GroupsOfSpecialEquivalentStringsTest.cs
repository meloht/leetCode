using leetCode._0851_0900;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0851_0900
{
    public class _893_GroupsOfSpecialEquivalentStringsTest
    {
        _893_GroupsOfSpecialEquivalentStringsAlg alg = new _893_GroupsOfSpecialEquivalentStringsAlg();
        
        [Fact]
        public void Test01()
        {
            string[] words = ["abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx"];
            int exp = 3;
            int res = alg.NumSpecialEquivGroups(words);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string[] words = ["abc", "acb", "bac", "bca", "cab", "cba"];
            int exp = 3;
            int res = alg.NumSpecialEquivGroups(words);
            Assert.Equal(exp, res);
        }
    }
}
