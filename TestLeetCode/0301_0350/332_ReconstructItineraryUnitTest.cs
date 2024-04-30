using leetCode._0301_0350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0301_0350
{
    [TestClass]
    public class _332_ReconstructItineraryUnitTest
    {
        _332_ReconstructItineraryAlg alg = new _332_ReconstructItineraryAlg();

        [TestMethod]
        public void TestCase01()
        {
            string[][] tickets = [["MUC", "LHR"], ["JFK", "MUC"], ["SFO", "SJC"], ["LHR", "SFO"]];
            string[] exp = ["JFK", "MUC", "LHR", "SFO", "SJC"];
            string[] res = alg.FindItinerary(tickets).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase02()
        {
            string[][] tickets = [["JFK", "SFO"], ["JFK", "ATL"], ["SFO", "ATL"], ["ATL", "JFK"], ["ATL", "SFO"]];
            string[] exp = ["JFK", "ATL", "JFK", "SFO", "ATL", "SFO"];
            string[] res = alg.FindItinerary(tickets).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }

        [TestMethod]
        public void TestCase03()
        {
            string[][] tickets = [["JFK", "KUL"], ["JFK", "NRT"], ["NRT", "JFK"]];
            string[] exp = ["JFK", "NRT", "JFK", "KUL"];
            string[] res = alg.FindItinerary(tickets).ToArray();
            Assert.IsTrue(exp.SequenceEqual(res));

        }
    }
}
