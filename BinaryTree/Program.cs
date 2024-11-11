using System;
using BinarySearch;
using BinaryTree;

namespace BinaryTree
{
    class BinaryTree
    {
        public static void Main()
        {
            //Only have 2 nodes per parent
            //To the left, there'll have the smaller numbers
            //To the right, there'll have the higher

            BinaryS bst = new BinaryS();
            bst.Insert(7, "Squirtle");
            bst.Insert(23, "Ekans");
            bst.Insert(151, "Mew");
            bst.Insert(4, "Charmander");
            bst.Insert(1, "Bulbasaur");

            Console.WriteLine(bst.Find(4));

            int value = 0;

            Console.ReadLine();
        }
    }
}