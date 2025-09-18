using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._3401_3450
{
    public class _3408_DesignTaskManagerAlg
    {
        public class TaskManager
        {
            private Dictionary<int, int[]> taskInfo;
            private PriorityQueue<int[], int[]> heap;


            public TaskManager(IList<IList<int>> tasks)
            {
                taskInfo = new Dictionary<int, int[]>();
                heap = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((a, b) =>
                {
                    if (a[0] == b[0])
                    {
                        return b[1].CompareTo(a[1]);
                    }
                    return b[0].CompareTo(a[0]);
                }));
                foreach (var task in tasks)
                {
                    int userId = task[0], taskId = task[1], priority = task[2];
                    taskInfo[taskId] = [priority, userId];
                    heap.Enqueue([priority, taskId], [priority, taskId]);
                }



            }

            public void Add(int userId, int taskId, int priority)
            {
                taskInfo[taskId] = [priority, userId];
                heap.Enqueue([priority, taskId], [priority, taskId]);
            }

            public void Edit(int taskId, int newPriority)
            {
                if (taskInfo.ContainsKey(taskId))
                {
                    taskInfo[taskId][0] = newPriority;
                    heap.Enqueue(new int[] { newPriority, taskId }, new int[] { newPriority, taskId });
                }


            }

            public void Rmv(int taskId)
            {
                taskInfo.Remove(taskId);
            }

            public int ExecTop()
            {
                while (heap.Count > 0)
                {
                    var task = heap.Dequeue();
                    int priority = task[0], taskId = task[1];
                    if (taskInfo.TryGetValue(taskId, out var info) && info[0] == priority)
                    {
                        int userId = info[1];
                        taskInfo.Remove(taskId);
                        return userId;
                    }
                }

                return -1;

            }


        }



    }
}
