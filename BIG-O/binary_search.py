def binary_search(lista,item):
    
    baixo : int = 0
    alto : int = len(lista) - 1

    while baixo <= alto:

        meio = (baixo + alto) // 2
        chute = lista[meio]

        if chute == item:
            return meio
        if chute > item:
            alto = meio - 1
        else:
            baixo = meio + 1
        
    return None
    
minha_lista = [1,3,5,7,9]

print(binary_search(minha_lista,3))
print(binary_search(minha_lista,-1))