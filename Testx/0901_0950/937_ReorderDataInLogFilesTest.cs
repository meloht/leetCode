using leetCode._0901_0950;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._0901_0950
{
    public class _937_ReorderDataInLogFilesTest
    {
        _937_ReorderDataInLogFilesAlg alg = new _937_ReorderDataInLogFilesAlg();

        [Fact]
        public void Test01()
        {
            string[] logs = ["dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"];
            string[] exp = ["let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6"];
            string[] res = alg.ReorderLogFiles(logs);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test02()
        {
            string[] logs = ["a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo"];
            string[] exp = ["g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7"];
            string[] res = alg.ReorderLogFiles(logs);
            Assert.Equal(exp, res);
        }

        [Fact]
        public void Test03()
        {
            string[] logs = ["1 n u", "r 527", "j 893", "6 14", "6 82"];
            string[] exp = ["1 n u", "r 527", "j 893", "6 14", "6 82"];
            string[] res = alg.ReorderLogFiles(logs);
            Assert.Equal(exp, res);
        }
    }
}
