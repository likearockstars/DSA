def main():

    arry = [20,4,5,3,32,40,1,2,49,90]

    print(linear_search(arry,49))

# Temporal -> O(n), Espacial O(1)
def linear_search(arry,target):

    for i in range(len(arry)):
        if arry[i] == target:
            return i
    return None
    


if __name__ == "__main__":
    main()
