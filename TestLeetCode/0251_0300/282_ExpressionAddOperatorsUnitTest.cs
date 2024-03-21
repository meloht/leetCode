using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0251_0300
{
    [TestClass]
    public class _282_ExpressionAddOperatorsUnitTest
    {
        _282_ExpressionAddOperatorsAlg alg = new _282_ExpressionAddOperatorsAlg();

        [TestMethod]
        public void TestCase01()
        {
            string num = "123";
            int target = 6;
            string[] exp = ["1+2+3", "1*2*3"];
            string[] res = alg.AddOperators(num,target).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase02()
        {
            string num = "232";
            int target = 8;
            string[] exp = ["2*3+2", "2+3*2"];
            string[] res = alg.AddOperators(num, target).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }


        [TestMethod]
        public void TestCase03()
        {
            string num = "3456237490";
            int target = 9191;
            string[] exp = [];
            string[] res = alg.AddOperators(num, target).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase04()
        {
            string num = "1234567890";
            int target = 9191;
            string[] exp = [];
            string[] res = alg.AddOperators(num, target).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }


        [TestMethod]
        public void TestCase05()
        {
            string num = "105";
            int target = 5;
            string[] exp = ["1*0+5", "10-5"];
            string[] res = alg.AddOperators(num, target).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }

        [TestMethod]
        public void TestCase06()
        {
            string num = "2147483648";
            int target = -2147483648;
            
            string[] exp = [];
            string[] res = alg.AddOperators(num, target).ToArray();
            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);

        }
    }
}
