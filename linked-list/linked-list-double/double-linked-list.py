class Node:
    
    def __init__(self,value):
        # Value
        self.value = value
        # Next nó
        self.next = None
        # Previous nó
        self.prev = None

class DoublyLinkedList:
    
    def __init__(self):        
        self.head = None
        self.tail = None
    
    def add_to_front(self,value):

        new_node = Node(value)

        if self.head is None:

            self.head = new_node
            self.tail = new_node
        else:
            new_node.next = self.head
            self.head.prev = new_node
            self.head = new_node
    
    def add_to_end(self,value):
        
        new_node = Node(value)

        if self.tail is None:
            self.head = new_node
            self.tail = new_node

        else:
            self.tail.next = new_node
            new_node.prev = self.tail
            self.tail = new_node


    def print_list(self):
        
        curr = self.head

        while curr != None:

            print(curr.value)
            curr = curr.next       



my_list = DoublyLinkedList()
my_list.add_to_front(1)
my_list.add_to_front(2)
my_list.add_to_end(1)

my_list.print_list()