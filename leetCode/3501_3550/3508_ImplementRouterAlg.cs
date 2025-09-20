﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3501_3550
{
    public class _3508_ImplementRouterAlg
    {
        public class Router
        {
            private record Packet(int Source, int Destination, int Timestamp);

            private class Pair
            {
                public List<int> Timestamps = new();
                public int Head = 0;
            }

            private readonly int memoryLimit;
            private readonly Queue<Packet> packetQ = new();
            private readonly HashSet<Packet> packetSet = new();
            private readonly Dictionary<int, Pair> destToTimestamps = new();

            public Router(int memoryLimit)
            {
                this.memoryLimit = memoryLimit;
            }

            public bool AddPacket(int source, int destination, int timestamp)
            {
                var packet = new Packet(source, destination, timestamp);
                if (!packetSet.Add(packet)) return false;
                if (packetQ.Count == memoryLimit) 
                    ForwardPacket();
                packetQ.Enqueue(packet);
                if (!destToTimestamps.ContainsKey(destination))
                    destToTimestamps[destination] = new Pair();
                destToTimestamps[destination].Timestamps.Add(timestamp);
                return true;
            }

            public int[] ForwardPacket()
            {
                if (packetQ.Count == 0) return Array.Empty<int>();
                var packet = packetQ.Dequeue();
                packetSet.Remove(packet);
                destToTimestamps[packet.Destination].Head++;
                return new int[] { packet.Source, packet.Destination, packet.Timestamp };
            }

            public int GetCount(int destination, int startTime, int endTime)
            {
                if (!destToTimestamps.ContainsKey(destination)) return 0;
                var p = destToTimestamps[destination];
                int left = LowerBound(p.Timestamps, startTime, p.Head);
                int right = LowerBound(p.Timestamps, endTime + 1, p.Head);
                return right - left;
            }

            private int LowerBound(List<int> nums, int target, int left)
            {
                int right = nums.Count;
                while (left < right)
                {
                    int mid = (left + right) >> 1;
                    if (nums[mid] >= target) right = mid;
                    else left = mid + 1;
                }
                return right;
            }
        }



    }
}
