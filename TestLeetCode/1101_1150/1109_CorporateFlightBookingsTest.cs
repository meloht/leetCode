using leetCode._1101_1150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._1101_1150
{
    [TestClass]
    public class _1109_CorporateFlightBookingsTest
    {
        _1109_CorporateFlightBookingsAlg alg = new _1109_CorporateFlightBookingsAlg();

        [TestMethod]
        public void Test01()
        {
            int[][] bookings = [[1, 2, 10], [2, 3, 20], [2, 5, 25]];
            int n = 5;
            int[] exp = [10, 55, 45, 25, 25];
            int[] res = alg.CorpFlightBookings(bookings, n);
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void Test02()
        {
            int[][] bookings = [[1, 2, 10], [2, 2, 15]];
            int n = 2;
            int[] exp = [10, 25];
            int[] res = alg.CorpFlightBookings(bookings, n);
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
