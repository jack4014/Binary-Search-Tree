using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BST
    {
        public Node root; //Pointer to the root node

        public BST() { root = null; } //Default constructor 

        public Node insert(Node p) //Insert numbers into tree nodes
        {
            Node temp = root;
            if (temp == null)
            {
                root = p;
                return root;
            }
            while (true)
            {
                if (p.num < temp.num)
                {
                    if (temp.left == null)
                    {
                        temp.left = p;
                        break;
                    }
                    temp = temp.left;
                }
                else
                {
                    if (temp.right == null)
                    {
                        temp.right = p;
                        break;
                    }
                    temp = temp.right;
                }
            }
            return root;
        }

        public Node search(int num) //Search the binary search tree
        {
            Node p = root;
            while (p != null)
            {
                if (p.num == num) { break; }
                if (p.num > num) { p = p.left; }
                if (p.num < num) { p = p.right; }
            }
            return p;
        }

        public int findHeight(Node p) //Method to find the height/depth of the binary search tree
        {
            if (p == null)
            {
                return 0;
            }
            int left = findHeight(p.left);
            int right = findHeight(p.right);
            int current = Math.Max(left, right) + 1;
            Console.WriteLine(current + " : " + p.num);
            return current;
        }

        public void inOrder(Node p) //Method for reading the binary search tree in order 
        {
            if (p == null) 
                return;
            inOrder(p.left);
            if (isPrime(p.num))
                Console.WriteLine(p.num);

            inOrder(p.right);
        }

        static Boolean isPrime(int num) //Method for calculating a prime
        {
            Boolean record = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if ((num % i) == 0)
                {
                    record = false;
                    break;
                }
            }
            if (num == 1)
            {
                record = false;
            }
            return (record);

        }
    }
}
