using System;
using System.Runtime.CompilerServices;
using TreeNode;

namespace BinarySearch
{
    class BinaryS
    {
        public TreeN Root = null;
        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }

        //2 Ways - Breadth First and Depth First
        //Traversal: 
        //Level(visit nodes on each level)
        //Pre-Order(visit root of every subtree first) (Node, L, R)
        //Post-Order(visit the root of every subtree last) (L, R, Node)
        //In-Order(visit left child, then root, then right child) (L, Node, R)

        public void PrintInOrderTraversal()
        {
            InOrderTraversal(Root); 
        }
        
        private void InOrderTraversal(TreeN node)
        {
            if(node != null)
            {
                InOrderTraversal(node.LeftChild);
                Console.WriteLine(node.key + " " + node.value);
                InOrderTraversal(node.RightChild);
            }
        }

        public void PrintPreOrderTraversal()
        {
            PreOrderTraversal(Root); 
        }
        
        private void PreOrderTraversal(TreeN node)
        {
            if(node != null)
            {
                Console.WriteLine(node.key + " " + node.value);
                InOrderTraversal(node.LeftChild); 
                InOrderTraversal(node.RightChild);
            }
        }

        public void PrintPostOrderTraversal()
        {
            PostOrderTraversal(Root); 
        }
        
        private void PostOrderTraversal(TreeN node)
        {
            if(node != null)
            {
                InOrderTraversal(node.LeftChild);
                InOrderTraversal(node.RightChild);
                Console.WriteLine(node.key + " " + node.value);
            }
        }
        //Ao instanciar um objeto da classe BinaryS, o atributo Root começa valendo null, ok. Apos isso, atraves do metodo Insert, 
        //o atributo Root recebe o metodo InsertItem, onde inicializa a arvore binaria.
        //Depois disso, o proximo galho vai vir e como é o mesmo objeto adicionando um novo dado, n é começado outra raiz, e sim, da sequencia aos galhos 
        public TreeN InsertItem(TreeN node, int key, string value)
        {
            TreeN newNode = new TreeN(key, value);

            //If this is the first time you insert, create the root
            if(node == null)
            {
                node = newNode;
                return node;
            }

            //If this isn't the first insert, traverse, find null, insert
            if(key < node.key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, key, value);
            }

            return node;
        }

        //Agora para econtrar, criamos um novo Galho para encontrar a posicao dele, o metodo Find que retorna uma string é usado para retornar 
        //o valor apos usar o outro metodo Find que retorno o galho, atraves das verificacoes para saber se esta na esquerda ou na direita 
        public string Find(int key)
        {
            TreeN node = Find(Root, key);
            return node == null ? null : node.value;
        }

        private TreeN? Find(TreeN node, int key)
        {
            if(node == null || node.key == key)
            {
                return node;
            }
            else if(key < node.key)
            {
                return Find(node.LeftChild, key);
            }
            else if(key > node.key)
            {
                return Find(node.RightChild, key);
            }
            return null;
        }
    }
}