class Product:

    # Inicializa o produto
    def __init__(self,name: str , code: int, description: str ,quantity : int, value: float):

       self.name = name
       self.code = code
       self.description = description
       self.quantity = quantity 
       self.value = value


    # Mostar  o objeto em forma de string
    def __str__(self):
        return(f"Name: {self.name}, code: {self.code},description: {self.description}, quantity: {self.quantity}, value: {self.value}")