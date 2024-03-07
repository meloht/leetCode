using leetCode._0401_0450;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0401_0450
{
    [TestClass]
    public class _401_BinaryWatchUnitTest
    {
        _401_BinaryWatchAlg alg = new _401_BinaryWatchAlg();

        [TestMethod]
        public void TestCase01()
        {
            int turnedOn = 1;
            string[] exp = ["0:01", "0:02", "0:04", "0:08", "0:16", "0:32", "1:00", "2:00", "4:00", "8:00"];
            string[] res = alg.ReadBinaryWatch(turnedOn).ToArray();

            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }

        [TestMethod]
        public void TestCase02()
        {
            int turnedOn = 9;
            string[] exp = [];
            string[] res = alg.ReadBinaryWatch(turnedOn).ToArray();

            bool bl = Utils.IsSameArr(exp, res);
            Assert.IsTrue(bl);
        }
    }
}
