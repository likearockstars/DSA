from node import Node
from product import Product

class Stock:

    # Inicialization head
    def __init__(self,head = None):
        # First element
        self.head = head

    
    # Append element in head
    def add_to_list(self,product):
        
        # New node
        new_node = Node(product)
        # new node -> head
        new_node.next = self.head
        # head receive new nod
        self.head = new_node#
    

    # printing all products
    def print_products(self):    
        curr = self.head

        while curr != None:

            print(curr.product)

            curr = curr.next

    # remove of value in list per code
    def remove_to_list(self,code):

        curr = self.head
        prev = None


        while curr != None:

            if curr.product.code == code:

                if prev is None:
                    self.head =  curr.next
                else:
                    prev.next = curr.next

                
                print(f"Produto do código '{code}' removido com sucesso.")
                return True
            
            prev  = curr
            curr = curr.next
        
        print(f"Produto do código '{code} não foi encontrado.'")
        return None
    
    # search product in list per code
    def search_element(self,code):

        curr = self.head

        while curr != None:
            
            if curr.product.code == code:

                return curr.product
            

            curr = curr.next
    
        return None

            