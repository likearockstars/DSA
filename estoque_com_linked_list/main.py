from product import Product
from stock import Stock

def main():

    print()
    choose_option()

    print()

def show_menu():
    
    print("1- Append product\n2- Remove product\n3- Printing products\n4- Search product\n5- Exit\n")
    print()

def choose_option() -> None:

    stock = Stock()

    while True:
        
        show_menu()

        # Pegar a opção do usuário.
        while True:
            try:
                option = get_number("Option: ")
                print()
                break
            except ValueError:
                pass
        
        match option:

            # Adicionar produtos
            case 1:
                product = create_product()
                stock.add_to_list(product)
                print(f"{product.name} added successfully")
                print()

            # Remover produtos
            case 2:
                removed_product_name : int = get_number("Enter a code of product to removed: ")
                stock.remove_to_list(removed_product_name)
                print()

            # Imprimir lista de produtos
            case 3:
                stock.print_products()
                print()

            # Procurar produto
            case 4:
                search_product : int = get_number("Enter a code of product to search: ")
                product : Product = stock.search_element(search_product)
                print(product)
                print()

            case 5:
                print("Bye")
                break


# Responsável por instância o produto é retornar a referência
def create_product() -> Product:


    name : str = input("Enter a name of product: ").lower().strip() 
    description : str = input("Enter a description of product: ").lower().strip()


    while True:
        try:
            code = int(input("Enter code of product: "))
            quantity = int(input("Enter a quantity of product: "))
            value = float(input("Enter the value of product: "))
            break
        except ValueError:
            pass
    
    print()

    return Product(name,code,description,quantity,value)

# Reponsável por pegar um número inteiro válido
def get_number(prompt: str ) -> int:

    while True:
        try:
            return int(input(prompt))
        except ValueError:
            pass

if __name__ == "__main__":
    main()