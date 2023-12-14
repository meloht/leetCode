using leetCode._1_50;
using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _51_NQueensUnitTest
    {
        _51_NQueensAlg alg;

        [TestInitialize]
        public void Init()
        {
            alg = new _51_NQueensAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.SolveNQueens(4);
            List<IList<string>> list = new List<IList<string>>();
            list.Add(new List<string>() { ".Q..", "...Q", "Q...", "..Q." });
            list.Add(new List<string>() { "..Q.", "Q...", "...Q", ".Q.." });
            bool bl = Utils.IsSameList(res, list);
            Assert.AreEqual(true, bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            var res = alg.SolveNQueens(1);
            List<IList<string>> list = new List<IList<string>>();
            list.Add(new List<string>() { "Q" });
         
            bool bl = Utils.IsSameList(res, list);
            Assert.AreEqual(true, bl);
        }
    }
}
