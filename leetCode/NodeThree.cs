using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class NodeThree
    {
        public int val;
        public NodeThree left;
        public NodeThree right;
        public NodeThree next;

        public NodeThree() { }

        public NodeThree(int _val)
        {
            val = _val;
        }

        public NodeThree(int _val, NodeThree _left, NodeThree _right, NodeThree _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}
