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
        public virtual void printLevelOrder()
        {
            int h = height(root);
            int i;
            for (i = 1; i <= h; i++)
            {
                printCurrentLevel(root, i);
            }
        }

        public virtual int height(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int lheight = height(root.left);
                int rheight = height(root.right);

                if (lheight > rheight)
                {
                    return (lheight + 1);
                }
                else
                {
                    return (rheight + 1);
                }
            }
        }

        public virtual void printCurrentLevel(Node root,
                                          int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.num + " ");
            }
            else if (level > 1)
            {
                printCurrentLevel(root.left, level - 1);
                printCurrentLevel(root.right, level - 1);
            }
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
            return Math.Max(left, right) + 1;
        }

        public void inOrder(Node p) //Method for reading the binary search tree in order 
        {
            if (p == null) return;
            inOrder(p.left);
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
            if (num == 0 || num == 1)
            {
                record = false;
            }
            return (record);

        }
        static void PrintPrime(int[] arr) //method for displaying prime number
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]))
                {
                    Console.WriteLine("\t{0}", arr[i]);
                }
            }

        }
    }
}
}

