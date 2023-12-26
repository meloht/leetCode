using leetCode._1_50;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetCode._0001_0050
{
    [TestClass]
    public class _50_PowxNUnitTest
    {
        _50_PowxNAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _50_PowxNAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            var res = alg.MyPow(2.00000d,10);

            Assert.AreEqual(1024.00000d, res);
        }


        [TestMethod]
        public void TestCase02()
        {
            var res = alg.MyPow(2.10000d, 3);

            Assert.AreEqual(9.26100d, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            var res = alg.MyPow(2.00000d, -2);

            Assert.AreEqual(0.25000d, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            var res = alg.MyPow(0.00001d, 2147483647);


            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase05()
        {
          
            
            var res = alg.MyPow(1.00000d, -2147483648);

          
            Assert.AreEqual(1.00000d, res);
        }
    }
}
