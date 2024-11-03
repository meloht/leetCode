﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode.Model.QuadTreeNode;

namespace leetCode._0551_0600
{
    public class _558_LogicalOrOfTwoBinaryGridsRepresentedAsQuadTreesAlg
    {
        public Node Intersect(Node quadTree1, Node quadTree2)
        {
            if (quadTree1.isLeaf)
            {
                if (quadTree1.val)
                {
                    return new Node(true, true,null,null,null,null);
                }
                return new Node(quadTree2.val, quadTree2.isLeaf, quadTree2.topLeft, quadTree2.topRight, quadTree2.bottomLeft, quadTree2.bottomRight);
            }
            if (quadTree2.isLeaf)
            {
                return Intersect(quadTree2, quadTree1);
            }
            Node o1 = Intersect(quadTree1.topLeft, quadTree2.topLeft);
            Node o2 = Intersect(quadTree1.topRight, quadTree2.topRight);
            Node o3 = Intersect(quadTree1.bottomLeft, quadTree2.bottomLeft);
            Node o4 = Intersect(quadTree1.bottomRight, quadTree2.bottomRight);
            if (o1.isLeaf && o2.isLeaf && o3.isLeaf && o4.isLeaf && o1.val == o2.val && o1.val == o3.val && o1.val == o4.val)
            {
                return new Node(o1.val, true, null, null, null, null);
            }
            return new Node(false, false, o1, o2, o3, o4);


        }
    }
}
