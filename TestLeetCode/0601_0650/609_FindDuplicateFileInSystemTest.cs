using leetCode._0601_0650;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0601_0650
{
    [TestClass]
    public class _609_FindDuplicateFileInSystemTest
    {
        _609_FindDuplicateFileInSystemAlg alg = new _609_FindDuplicateFileInSystemAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[] paths = ["root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)"];
            string[][] exp = [["root/a/2.txt", "root/c/d/4.txt", "root/4.txt"], ["root/a/1.txt", "root/c/3.txt"]];
            IList<IList<string>> res = alg.FindDuplicate(paths);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            string[] paths = ["root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)"];
            string[][] exp = [["root/a/2.txt", "root/c/d/4.txt"], ["root/a/1.txt", "root/c/3.txt"]];
            IList<IList<string>> res = alg.FindDuplicate(paths);
            bool bl = Utils.IsSame(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
