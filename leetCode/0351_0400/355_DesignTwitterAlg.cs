using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0351_0400
{
    public class _355_DesignTwitterAlg
    {
        public class Twitter
        {
            Dictionary<int, HashSet<int>> dictF = new Dictionary<int, HashSet<int>>();
            Dictionary<int, PriorityQueue<int, int>> dictTw = new Dictionary<int, PriorityQueue<int, int>>();

            int time = 0;
            public Twitter()
            {

            }

            public void PostTweet(int userId, int tweetId)
            {
                if (!dictTw.ContainsKey(userId))
                {
                    dictTw.Add(userId, new PriorityQueue<int, int>());
                }
               
                var queue = dictTw[userId];
                queue.Enqueue(tweetId, time++);
                if (queue.Count > 10)
                {
                    queue.Dequeue();
                }
            }

            public IList<int> GetNewsFeed(int userId)
            {
                PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
                if (dictF.ContainsKey(userId))
                {
                    var fs = dictF[userId];
                    foreach (int id in fs)
                    {
                        if (dictTw.ContainsKey(id))
                        {
                            var userQueue = dictTw[id].UnorderedItems;
                            foreach (var item in userQueue)
                            {
                                queue.Enqueue(item.Element, item.Priority);
                            }
                        }
                    }
                }
                if (dictTw.ContainsKey(userId))
                {
                    var userQueue = dictTw[userId].UnorderedItems;
                    foreach (var item in userQueue)
                    {
                        queue.Enqueue(item.Element, item.Priority);
                    }
                }
                while (queue.Count > 10)
                {
                    queue.Dequeue();
                }
                List<int> list = new List<int>();
                while (queue.Count > 0)
                {
                    list.Add(queue.Dequeue());
                }
                list.Reverse();
                return list;
            }

            public void Follow(int followerId, int followeeId)
            {
                if (!dictF.ContainsKey(followerId))
                {
                    dictF.Add(followerId, new HashSet<int>());
                }
                dictF[followerId].Add(followeeId);
            }

            public void Unfollow(int followerId, int followeeId)
            {
                if (dictF.ContainsKey(followerId) && dictF[followerId].Contains(followeeId))
                {
                    dictF[followerId].Remove(followeeId);
                }
            }
        }
    }
}
