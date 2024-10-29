def main():
    
    quadratic_time([1,2,3,4,5,6,7])

# 0(n^2) Quadratic Time,O(7 ^ 2)
def quadratic_time(lista: list):

    for i in range(len(lista)):
        for j in range(len(lista)):
            print(f"{i} - {j}")


if __name__ == "__main__":
    main()