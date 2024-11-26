from Node import Node

class linkedList:

    def __init__(self):
        self.head = None
    
    
    def add_item(self,value):
        
        new_node = Node(value)
        new_node.next = self.head
        self.head = new_node
    
    def remove_item(self,data):

        curr = self.head
        prev = None

        while curr is not None:
            
            if curr.data == data:

                if prev is None:
                    curr = curr.next
                else:
                    prev.next = curr.next
                
                return True
            
            prev = curr
            curr = curr.next
        
        return False
    
    def search(self,data):

        curr = self.head

        while curr is not None:

            if curr.data == data:
                return True
            
            curr = curr.next
            
        return False
    
    def print_list(self):

        curr = self.head
        elements = []

        while curr is not None:
            
            elements.append(str(curr.data))
            curr = curr.next
        
        print(" -> ".join(elements))
        




