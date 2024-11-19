from node import Node

class List:

    def __init__(self,head: Node = None ):

        # head -> Node -> [value,node]
        self.head = head
    

    def add_item(self,value: float) -> None:
            # instânciando um nó: [valor,node]
            node: Node = Node(value,self.head)
            # Próximo nó passar a ser a head
            self.head = node

    
    def print_list(self):
            node_actually: Node = self.head

            while node_actually is not None:

                  print(node_actually.value)

                  # Move para o próximo nó (que é o nó apontado pelo atual)
                  node_actually = node_actually.node

        