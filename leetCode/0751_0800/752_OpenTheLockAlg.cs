using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0751_0800
{
    public class _752_OpenTheLockAlg
    {
        public int OpenLock(string[] deadends, string target)
        {

            HashSet<string> keys = new HashSet<string>();
            HashSet<string> keysEx = new HashSet<string>(deadends);
            if (keysEx.Contains("0000"))
                return -1;

            if (target == "0000")
                return 0;


            Queue<string> queue = new Queue<string>();

            queue.Enqueue("0000");
            int ans = 0;

            while (queue.Count > 0)
            {
                ans++;
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    string item = queue.Dequeue();
                  
                    StringBuilder sb = new StringBuilder(item);
                    for (int k = 0; k < 4; k++)
                    {
                        char old = item[k];
                        sb[k] = GetPrev(item[k]);
                        if (Check(sb.ToString(), keys, keysEx, queue, target))
                        {
                            return ans;
                        }
                        sb[k] = old;

                        sb[k] = GetNext(item[k]);
                        if (Check(sb.ToString(), keys, keysEx, queue, target))
                        {
                            return ans;
                        }
                        sb[k] = old;
                    }
                }
            }
            return -1;
        }
        private bool Check(string s,HashSet<string> keys, HashSet<string> keysEx, Queue<string> queue,string target)
        {
            if (!keysEx.Contains(s) && !keys.Contains(s))
            {
                if (s == target)
                {
                    return true;
                }
                queue.Enqueue(s);
                keys.Add(s);
            }
            return false;
        }

        private char GetPrev(char val)
        {
            if (val == '0')
            {
                return '9';
            }
            return (char)(val - 1);
        }
        private char GetNext(char val)
        {
            if (val == '9')
            {
                return '0';
            }
            return (char)(val + 1);
        }


    }
}
