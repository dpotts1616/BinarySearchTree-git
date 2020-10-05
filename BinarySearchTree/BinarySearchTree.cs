using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //member variables
        public Node root;

        //constructor
        public BinarySearchTree()
        {
            root = null;
        }

        //methods
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node currentNode = root;
                while(currentNode.left != null || currentNode.right != null)
                {
                    if (newNode.data < currentNode.data && currentNode.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                    else if (newNode.data >= currentNode.data && currentNode.right != null)
                    {
                        currentNode = currentNode.right;
                    }
                    else
                    {
                        break;
                    }
                }

                if (newNode.data < currentNode.data)
                {
                    currentNode.left = newNode;
                }
                if (newNode.data >= currentNode.data)
                {
                    currentNode.right = newNode;
                }
            }
        }

        public bool Search(int value)
        {
            Node currentNode = root;
            while (currentNode.left != null || currentNode.right != null)
            {
                
                if (value < currentNode.data && currentNode.left != null)
                {
                    currentNode = currentNode.left;
                }
                else if (value > currentNode.data && currentNode.right != null)
                {
                    currentNode = currentNode.right;
                }

                if (currentNode.data == value)
                {
                    return true;
                }

                if (currentNode.left == null && currentNode.right == null)
                {
                    break;
                }
            }

            return false;
        }
    }
}
