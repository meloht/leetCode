using static leetCode._0901_0950._911_OnlineElectionAlg;

namespace Testx._0901_0950
{
    public class _911_OnlineElectionTest
    {
        [Fact]
        public void Test01()
        {
            TopVotedCandidate topVotedCandidate = new TopVotedCandidate([0, 1, 1, 0, 0, 1, 0], [0, 5, 10, 15, 20, 25, 30]);
            Assert.Equal(0, topVotedCandidate.Q(3)); // 返回 0 ，在时刻 3 ，票数分布为 [0] ，编号为 0 的候选人领先。
            Assert.Equal(1, topVotedCandidate.Q(12)); // 返回 1 ，在时刻 12 ，票数分布为 [0,1,1] ，编号为 1 的候选人领先。
            Assert.Equal(1, topVotedCandidate.Q(25)); // 返回 1 ，在时刻 25 ，票数分布为 [0,1,1,0,0,1] ，编号为 1 的候选人领先。（在平局的情况下，1 是最近获得投票的候选人）。
            Assert.Equal(0, topVotedCandidate.Q(15)); // 返回 0
            Assert.Equal(0, topVotedCandidate.Q(24)); // 返回 0
            Assert.Equal(1, topVotedCandidate.Q(8)); // 返回 1
        }
    }
}
