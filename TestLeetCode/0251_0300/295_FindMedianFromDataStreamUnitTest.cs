using leetCode._0251_0300;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0251_0300._295_FindMedianFromDataStreamAlg;

namespace Test._0251_0300
{
    [TestClass]
    public class _295_FindMedianFromDataStreamUnitTest
    {


        [TestMethod]
        public void TestCase01()
        {
            _295_FindMedianFromDataStreamAlg.MedianFinder medianFinder = new _295_FindMedianFromDataStreamAlg.MedianFinder();

            medianFinder.AddNum(1);    // arr = [1]
            medianFinder.AddNum(2);    // arr = [1, 2]
            Assert.AreEqual(1.5d, medianFinder.FindMedian()); // 返回 1.5 ((1 + 2) / 2)
            medianFinder.AddNum(3);    // arr[1, 2, 3]
            Assert.AreEqual(2.0d, medianFinder.FindMedian()); // return 2.0
        }
    }
}
