using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string[] file1 = System.IO.File.ReadAllLines(@"..\..\..\file1.txt"); //Read contents of the first designated file
                string[] file2 = System.IO.File.ReadAllLines(@"..\..\..\file2.txt"); //Read contents of the second designated file
                string[] file3 = System.IO.File.ReadAllLines(@"..\..\..\file3.txt"); //Read contents of the third designated file

                int[] arr = Array.ConvertAll(file1, int.Parse); //Converts the contents of the first file into an integer array
                int[] arr2 = Array.ConvertAll(file2, int.Parse); //Converts the contents of the second file into an integer array
                int[] arr3 = Array.ConvertAll(file3, int.Parse); //Converts the contents of the third file into an integer array

                BST tree = new BST(); //Create the first binary search tree
                BST tree2 = new BST(); //Create the second binary search tree
                BST tree3 = new BST(); //Create the third binary search tree

                for (int i = 0; i < arr.Length; i++) //For loop to insert the first array into the binary search tree
                {
                    Node p = new Node(arr[i]);
                    tree.insert(p);
                }

                for (int i = 0; i < arr2.Length; i++) //For loop to insert the second array into the binary search tree
                {
                    Node p = new Node(arr2[i]);
                    tree2.insert(p);
                }

                for (int i = 0; i < arr3.Length; i++) //For loop to insert the third array into the binary search tree
                {
                    Node p = new Node(arr3[i]);
                    tree3.insert(p);
                }

                Console.WriteLine("This is the first binary search tree");
                tree.inOrder(tree.root);
                Console.WriteLine("Level order traversal "
                          + "of binary tree is ");
                tree.printLevelOrder();
                Console.WriteLine("\nThe Prime numbers of this BST are");
                tree.inOrderPrimes(tree.root);
                Console.WriteLine("The height of the tree is {0}", tree.height(tree.root));

                Console.WriteLine("\nThis is the second binary search tree");
                tree2.inOrder(tree2.root);
                Console.WriteLine("Level order traversal "
                          + "of binary tree is ");
                tree2.printLevelOrder();
                Console.WriteLine("\nThe Prime numbers of this BST are");
                tree2.inOrderPrimes(tree2.root);
                Console.WriteLine("The height of the tree is {0}", tree2.height(tree2.root));

                Console.WriteLine("\nThis is the third binary search tree");
                tree3.inOrder(tree3.root);
                Console.WriteLine("Level order traversal "
                          + "of binary tree is ");

                tree3.printLevelOrder();
                Console.WriteLine("\nThe Prime numbers of this BST are");
                tree3.inOrderPrimes(tree3.root);
                Console.WriteLine("\nThe height of the tree is {0}", tree3.height(tree3.root));

            }
            catch (FormatException error_1) //Format error handling 
            {
                Console.WriteLine("Formatting Error");
                Console.WriteLine(error_1.Message);
            }
            catch (FileNotFoundException error_2) //File not found error handling
            {
                Console.WriteLine("File Not Found");
                Console.WriteLine(error_2.Message);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();


        }
    }
}
