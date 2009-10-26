/* Author : Sushma Kyasaralli Thimmappa */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParallelPrototype
{
    class Node
    {
        public string varName;
        public Node lhs;
        public Node rhs;
    }

    class NodeTraversal
    {
        StringBuilder str;
        StringBuilder instr;
        public NodeTraversal()
        {
            
        }

        public StringBuilder preOrder(int i,Node r)
        {
            if (i==1)
            {
                str = new StringBuilder(1000);
                str.Append('p');
            }
            if (r != null)
            {
                str.Append(r.varName);
                preOrder(0,r.lhs);
                preOrder(0,r.rhs);
            }

            return str;
        }

        public StringBuilder inOrder(int i, Node r)
        {
            if (i == 1)
            {
                instr = new StringBuilder(1000);
                instr.Append('i');
            }
            if (r != null)
            {
                inOrder(0, r.lhs);
                instr.Append(r.varName);
                inOrder(0, r.rhs);
            }

            return instr;
        }

    }

}
