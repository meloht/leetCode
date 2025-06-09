using leetCode._1001_1050;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testx._1001_1050
{
    public class _1023_CamelcaseMatchingTest
    {
        _1023_CamelcaseMatchingAlg alg = new _1023_CamelcaseMatchingAlg();

        [Fact]
        public void Test01()
        {
            string[] queries = ["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"];
            string pattern = "FB";
            bool[] exp = [true, false, true, true, false];
            bool[] res = alg.CamelMatch(queries, pattern).ToArray();
            Assert.Equal(exp, res);

        }

        [Fact]
        public void Test02()
        {
            string[] queries = ["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"];
            string pattern = "FoBa";
            bool[] exp = [true, false, true, false, false];
            bool[] res = alg.CamelMatch(queries, pattern).ToArray();
            Assert.Equal(exp, res);

        }

        [Fact]
        public void Test03()
        {
            string[] queries = ["FooBar", "FooBarTest", "FootBall", "FrameBuffer", "ForceFeedBack"];
            string pattern = "FoBaT";
            bool[] exp = [false, true, false, false, false];
            bool[] res = alg.CamelMatch(queries, pattern).ToArray();
            Assert.Equal(exp, res);

        }

        [Fact]
        public void Test04()
        {
            string[] queries = ["CompetitiveProgramming", "CounterPick", "ControlPanel"];
            string pattern = "CooP";
            bool[] exp = [false, false, true];
            bool[] res = alg.CamelMatch(queries, pattern).ToArray();
            Assert.Equal(exp, res);

        }
    }


}
