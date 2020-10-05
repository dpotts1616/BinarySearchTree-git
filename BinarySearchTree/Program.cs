using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(100);
            tree.Add(103);
            tree.Add(76);
            tree.Add(98);
            tree.Add(56);
            tree.Add(101);
            tree.Add(120);
            tree.Add(92);


            bool search76 = tree.Search(76);
            Console.WriteLine($"This tree contains 76: {search76}");

            bool search98 = tree.Search(98);
            Console.WriteLine($"This tree contains 98: {search98}");

            bool search145 = tree.Search(145);
            Console.WriteLine($"This tree contains 145: {search145}");

            bool search64 = tree.Search(64);
            Console.WriteLine($"This tree contains 64: {search64}");

            bool search92 = tree.Search(92);
            Console.WriteLine($"This tree contains 92: {search92}");

            Console.ReadLine();

        }
    }
}
