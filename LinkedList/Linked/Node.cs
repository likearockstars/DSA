using System;

namespace Nod
{
    class Node
    {
        public Node? Next;
        public int Data;

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }

    }
}