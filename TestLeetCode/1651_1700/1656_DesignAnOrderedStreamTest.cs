using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._1651_1700._1656_DesignAnOrderedStreamAlg;

namespace Test._1651_1700
{
    [TestClass]
    public class _1656_DesignAnOrderedStreamTest
    {
        [TestMethod]
        public void TestCase01()
        {
            OrderedStream os = new OrderedStream(5);
            List<string> exp = new List<string>();

            IList<string> res = os.Insert(3, "ccccc"); // 插入 (3, "ccccc")，返回 []
            Assert.IsTrue(exp.SequenceEqual(res));
            exp = ["aaaaa"];
            res = os.Insert(1, "aaaaa"); // 插入 (1, "aaaaa")，返回 ["aaaaa"]
            Assert.IsTrue(exp.SequenceEqual(res));
            exp = ["bbbbb", "ccccc"];
            res = os.Insert(2, "bbbbb"); // 插入 (2, "bbbbb")，返回 ["bbbbb", "ccccc"]
            Assert.IsTrue(exp.SequenceEqual(res));
            exp = [];
            res = os.Insert(5, "eeeee"); // 插入 (5, "eeeee")，返回 []
            Assert.IsTrue(exp.SequenceEqual(res));
            exp = ["ddddd", "eeeee"];
            res = os.Insert(4, "ddddd"); // 插入 (4, "ddddd")，返回 ["ddddd", "eeeee"]
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
