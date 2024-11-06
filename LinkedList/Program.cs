using System;
using Linke;
using Nod;

namespace LinkedList
{
    class LinkedList
    {
        public static void Main()
        {
            Linked linked = new Linked();
            linked.InsertFirst(10);
            linked.InsertFirst(20);
            linked.InsertFirst(30);

            linked.DisplayList();

            Console.WriteLine("----------------------");

            linked.DeleteFirst();
            linked.DeleteFirst();

            linked.DisplayList();


            Console.ReadLine();
        }
    }
}