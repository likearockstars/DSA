
from linked_list import linkedList

def main():
     
     print("\n")


def showMenu():

    print()
    print("1- add item\n2- remove item\n3- search item\n4- printing list\n5- exit\n")
    print()

def  operations_linked_list() -> None:
    
    my_list = linkedList()

    showMenu()
    
    while True:
        
        option = get_number("Your choice: ")
        print("\n")

        match option:

                case 1:
                    my_list.add_item(get_number("Enter a number: "))
                case 2:
                    my_list.remove_item(get_number("Enter a number: "))
                case 3:
                  answer = my_list.search(get_number("Enter a number: "))
                  print(answer)
                case 4:
                    my_list.print_list()
                case 5:
                    break

        showMenu()


def get_number(prompt: staticmethod):
     
     while True:
        
          try:
               return int(input(prompt))
          except ValueError:
               pass
          
if __name__ == "__main__":
    main()