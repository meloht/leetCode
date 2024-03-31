using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _331_VerifyPreorderSerializationOfABinaryTreeUnitTest
    {
        _331_VerifyPreorderSerializationOfABinaryTreeAlg alg = new _331_VerifyPreorderSerializationOfABinaryTreeAlg();


        [TestMethod]
        public void TestCase01()
        {
            string preorder = "9,3,4,#,#,1,#,#,2,#,6,#,#";
            bool exp = true;
            bool res = alg.IsValidSerialization(preorder);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string preorder = "1,#";
            bool exp = false;
            bool res = alg.IsValidSerialization(preorder);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string preorder = "9,#,#,1";
            bool exp = false;
            bool res = alg.IsValidSerialization(preorder);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string preorder = "#";
            bool exp = true;
            bool res = alg.IsValidSerialization(preorder);
            Assert.AreEqual(exp, res);
        }

    }
}
