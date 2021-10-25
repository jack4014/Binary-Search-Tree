using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Node
    {
        //public int data;
        public Node right;
        public Node left;
        public int num;

        public Node(int num) //Constructor
        {
            //data = num;
            this.num = num;
            left = null;
            right = null;
        }
    }
}
