using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._0301_0350
{
    public class _331_VerifyPreorderSerializationOfABinaryTreeAlg
    {
        public bool IsValidSerialization(string preorder)
        {
            if (preorder[0] == '#' && preorder.Length > 2)
                return false;
            if (preorder[0] == '#' && preorder.Length == 1)
                return true;
            string[] nodes = preorder.Split(',', StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(nodes[0]);
            int index = 1;
            while (queue.Count > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    queue.Dequeue();
                    int dec = nodes.Length - index;
                    if (dec < 2)
                        return false;
                    int len = index + 2;
                    for (; index < len; index++)
                    {
                        if (nodes[index] != "#")
                        {
                            queue.Enqueue(nodes[index]);
                        }
                    }
                }
            }
            if (index != nodes.Length)
            {
                return false;
            }

            return true;
        }
    }
}
