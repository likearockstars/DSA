using System;
using Nod;
namespace Linke
{
    class Linked
    {
        public Node? First;

        //Entao, mais uma vez, o First foi criado e esta apontando para o inicio da lista, ao criar um newNode, atribuimos a ele um dado, 
        //posteriormente, fazemos ele apontar para o First, que esta apontando para o inicio da lista, 
        //entao agora o newNode aponta para o inicio da lista,
        //e por fim, o First passa a apontar para o newNode, voltando a apontar para o inicio da lista.
        //Atua como se estivesse empurrando os elementos, fazendo com que o novo sempre seja o primeiro.
        public void InsertFirst(int data)
        {
            //Create new Node
            Node newNode = new Node();
            //Insert Data
            newNode.Data = data;
            //Assign to the next head
            newNode.Next = First;
            //Make the old node the new node
            First = newNode;
        }

        
        //Agora no metodo DeleteFirst ele cria uma variavel que passa a apontar para o First, ou seja, 
        //a primeira posicao da lista, posteriormente, o First aponta para ele mesmo, ou seja, 
        //a variavel temporaria armazenou a referencia da primeira posicao da lista,
        //e depois o First ao apontar para o proximo no dele mesmo, acaba excluindo a variavel temporaria,
        //desconectando ela da lista, ja que agora nada se conecta a ela, e retorna a variavel temporaria.
        public Node DeleteFirst()
        {
            if(First == null)
            {
                return null;
            }
            //Assign temporary variable
            Node temp = First;
            //Assign the new head
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Node Current = First;
            while(Current != null)
            {
                Console.WriteLine(Current.Data);
                Current = Current.Next;
            }
        }
    }
}