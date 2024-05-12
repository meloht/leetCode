using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0351_0400._355_DesignTwitterAlg;

namespace Test._0351_0400
{
    [TestClass]
    public class _355_DesignTwitterUnitTest
    {
        [TestMethod]
        public void TestCase01()
        {
            Twitter twitter = new Twitter();
            twitter.PostTweet(1, 5); // 用户 1 发送了一条新推文 (用户 id = 1, 推文 id = 5)
            var res1 = twitter.GetNewsFeed(1);  // 用户 1 的获取推文应当返回一个列表，其中包含一个 id 为 5 的推文
            Assert.IsTrue(res1.SequenceEqual([5]));
            twitter.Follow(1, 2);    // 用户 1 关注了用户 2
            twitter.PostTweet(2, 6); // 用户 2 发送了一个新推文 (推文 id = 6)
            var res2 = twitter.GetNewsFeed(1);  // 用户 1 的获取推文应当返回一个列表，其中包含两个推文，id 分别为 -> [6, 5] 。推文 id 6 应当在推文 id 5 之前，因为它是在 5 之后发送的
            Assert.IsTrue(res2.SequenceEqual([6, 5]));
            twitter.Unfollow(1, 2);  // 用户 1 取消关注了用户 2
            var res3 = twitter.GetNewsFeed(1);  // 用户 1 获取推文应当返回一个列表，其中包含一个 id 为 5 的推文。因为用户 1 已经不再关注用户 2
            Assert.IsTrue(res3.SequenceEqual([5]));
        }

        [TestMethod]
        public void TestCase02()
        {
            Twitter twitter = new Twitter();
            twitter.PostTweet(1, 5);
            twitter.Follow(1, 2);
            twitter.Follow(2, 1);

            var res1 = twitter.GetNewsFeed(2);
            twitter.PostTweet(2, 6);

            res1 = twitter.GetNewsFeed(1);

            var res2 = twitter.GetNewsFeed(2);

        }
    }
}
