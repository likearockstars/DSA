def main():
    class Node:
        # Node => [data,reference]
        def __init__(self, data, next=None):
            self.data = data # -> Valor
            self.next = next # -> Refence to next element

    class LinkedList:
        def __init__(self, head=None):
            
            # Primeiro elemento
            self.head = head

        def add_item(self, data):
            """
                1- Instânciando um novo Node[value,None]
                2- Node -> para o primeiro elemento da lista
                3- Esse novo Node inserido vai virar o primeiro elemento é a head

                Complexity temporal is O(1), em uma linked list, a referência da head é sempre obtida pelo desenvolvedor fazendo a complexity temporal ser O(1).
            """
            new_node = Node(data)
            new_node.next = self.head
            self.head = new_node
        
        def remove_item(self, data):
            """
                1- Elemento atual = head
                2- Elemento anterior = None

             Se o nó a ser removido for o primeiro nó (ou seja, o nó apontado por head), o ponteiro head será atualizado para apontar para o próximo nó de curr (ou seja, curr.next).

            Caso contrário, o nó anterior (prev) terá sua referência next atualizada para apontar para o próximo nó de curr (ou seja, curr.next), efetivamente removendo curr da lista. 

            Complexity temporal is O(N)

            """
            curr = self.head
            prev = None

            while curr != None:
                if curr.data == data:
                    
                    if prev is None:
                        self.head = curr.next
                    else:
                        prev.next = curr.next
                    
                    return True

                # Node recebe o node atual
                prev = curr
                # node atual recebe o node que ele aponta
                curr = curr.next
        
        def search(self,data):

            """
              1-  A variável curr recebe o primeiro elemento
              2-  O Loop continua enquanto existir nodes
              3-  Retorna True se o elemento existir
              4-  Retorna False se o elemento não existir
            """
            
            curr = self.head

            while curr != None:

                if curr.data == data:
                    return True
                
                curr = curr.next
            
            return False
            

        def show_list(self):

            """
            Recebe o primeiro nó: A função começa com o primeiro nó da lista, apontado por self.head, e começa a percorrer a lista a partir desse ponto.

            Adiciona todos os nós convertidos para uma str(): A função percorre cada nó, converte o valor de cada nó para uma string (str()), e armazena essas representações em uma lista auxiliar chamada elements.

            Faz a concatenação usando " -> ": Após percorrer todos os nós, a lista de strings elements é unida em uma única string, com cada elemento separado por " -> ".

            Forma uma lista: A string resultante será no formato esperado, como "7 -> 4 -> 3 -> 1", que representa a lista encadeada.
            """

            curr = self.head
            elements = []

            while curr != None:
                elements.append(str(curr.data))
                curr = curr.next

            print(" -> ".join(elements))

    linked_list = LinkedList()

    linked_list.add_item(1)
    linked_list.add_item(3)
    linked_list.add_item(4)
    linked_list.add_item(7)

    linked_list.remove_item(4)
    
    print(linked_list.search(3))

    linked_list.show_list()

if __name__ == "__main__":
    main()
