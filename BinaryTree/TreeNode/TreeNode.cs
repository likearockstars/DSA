using System;

namespace TreeNode
{
    class TreeN
    {
        public int key;
        public string value;
        public TreeN LeftChild;
        public TreeN RightChild;

        public TreeN(int key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}