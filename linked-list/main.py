from linkedlist import List

def main():

    print("\n")
    # Instância a lista 
    my_list = List()

    while True:
        # Mostra o menu para o usuário
        showMenu()

        while True:
            # Verifica se a entrada de dados (option) é valida
            try:
                option : int = int(input("Enter a option: "))
                if option not in[1,2,3]: continue
                break
            except ValueError:
                pass

        match option:
            case  1:
                # Verifica se o valor é valido
                while True:
                    try:
                        # Pega um valor float
                        value : float = float(input("Enter a value: "))
                        # Adiciona na lista
                        my_list.add_item(value)
                        # Encerra o loop
                        break
                    except ValueError:
                        pass
            case 2:
                   # Imprime a lista 
                   my_list.print_list()
            case 3:
                print("Bye!")
                break
            case _:
                pass
    
    print("\n")


def showMenu() -> None:
    
    print("1- Insert element: ")
    print("2- Remove element: ")
    print("3- Exit")
    print()

if __name__ == "__main__":
    main()