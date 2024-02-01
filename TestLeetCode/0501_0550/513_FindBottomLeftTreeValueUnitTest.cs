using leetCode._0501_0550;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0501_0550
{
    [TestClass]
    public class _513_FindBottomLeftTreeValueUnitTest
    {
        _513_FindBottomLeftTreeValueAlg alg = new _513_FindBottomLeftTreeValueAlg();

        [TestMethod]
        public void TestCase01()
        {
            int?[] root = [2, 1, 3];
            var tree = Utils.BuildTree(root);
            int exp = 1;
            int res = alg.FindBottomLeftValue(tree);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int?[] root = [1, 2, 3, 4, null, 5, 6, null, null, 7];
            var tree = Utils.BuildTree(root);
            int exp = 7;
            int res = alg.FindBottomLeftValue(tree);
            Assert.AreEqual(exp, res);
        }

       
    }
}
